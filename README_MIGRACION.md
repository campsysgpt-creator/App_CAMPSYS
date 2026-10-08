# Migración CAMPSYS → MVP + EF Core (estilo VetCare)

## ✅ Completado

### 1. Fundación EF Core (aplica a todo el sistema)
- `Models/Entities/` — 8 entidades (Departamento, Campista, Tutor, Staff, Cabana,
  Actividades, Inscripcion, DetalleInscripcionActividad), con propiedades PascalCase
  y navegación entre relaciones (antes eran POCOs planos con `id_campista`, etc.)
- `Data/CampsysDbContext.cs` — mapeo fiel a tu script SQL: mismos nombres de columna
  (`HasColumnName`), mismos `MaxLength`, mismos `DEFAULT` (`Activo`, `Campista`, `100.00`),
  mismo índice único en `doc_id`, mismas FKs con los mismos nombres de constraint.
- `appsettings.json` — reemplaza tu `App.config`. **Debes editar la cadena de conexión**
  con tu usuario real (`usersami123`) o tu autenticación de Windows.

### 2. FormInscripcion migrado 100% a MVP
- `View/Interfaces/IInscripcionView.cs` — el contrato entre la vista y la lógica
- `View/Interfaces/ItemsDeBinding.cs` — records para los combos (ver nota abajo)
- `Presenters/InscripcionPresenter.cs` — toda la lógica que antes vivía en el formulario
  y en `logicainscripcion`/`logicacampista`, ahora usando LINQ contra EF Core
  en lugar de `SqlCommand`/`SqlDataReader`
- `View/FormInscripcion.cs` — el formulario ya NO tiene lógica de negocio, solo
  implementa la interfaz y reenvía eventos al Presenter
- `View/FormInscripcion.Designer.cs` y `.resx` — **sin tocar**, tu diseño visual
  se mantiene intacto
- `View/FrmMensaje.cs/.Designer.cs/.resx` — copiados tal cual, solo cambié el namespace

### ⚠️ Detalle técnico importante que corregí
Al planear el binding de los combos (`cmbdepartamento`, `cmbcabana`, `lstactividades`)
iba a usar tuplas de C# (`(int Id, string Nombre)`). **No hubiera funcionado**: WinForms
usa reflexión en tiempo de ejecución para `DisplayMember`/`ValueMember`, y los nombres
de campo de una tupla solo existen en tiempo de compilación — en runtime son
`Item1`, `Item2`. Por eso usé `record` (`DepartamentoItem`, `CabanaItem`, `ActividadItem`),
que sí generan propiedades reales.

## ⏳ Pendiente (para replicar el mismo patrón)

| Formulario | Reemplaza lógica de | Complejidad |
|---|---|---|
| `FormModificar` | `logicacampista`, `logicatutor` (update) | Media |
| `FormStaff` | `logicastaff` | Media |
| `FormVisualizacion` | listados/reportes (varias `logica*.ObtenerTodos()`) | Baja |
| `FormPrincipal` | contenedor/menú principal | Baja (poca lógica) |

**Receta para cada uno** (la que ya aplicamos en FormInscripcion):
1. Copiar `.Designer.cs` y `.resx` del formulario viejo tal cual (solo cambiar namespace a `App_CAMPSYS.View`)
2. Crear `View/Interfaces/I<Form>View.cs` con las propiedades/eventos que el Presenter necesita
3. Crear `Presenters/<Form>Presenter.cs` migrando la lógica de la clase `logica*` correspondiente a LINQ/EF Core
4. Reescribir `View/<Form>.cs` para que solo implemente la interfaz y reenvíe eventos crudos de WinForms al Presenter

## Instalación de paquetes
Los `PackageReference` ya están en el `.csproj` (igual que VetCare). Al abrir la solución
en Visual Studio con internet disponible, NuGet los restaura automáticamente
(no necesitas instalarlos manualmente como con Newtonsoft.Json).

## Primera ejecución
1. Ajusta `appsettings.json` con tu cadena de conexión real
2. Como la BD ya existe (no partimos de cero con Migrations), puedes seguir usándola tal cual;
   EF Core no la va a recrear a menos que corras `Add-Migration`/`Update-Database`
3. Compila y ejecuta — arranca directo en `FormInscripcion` (ver `Program.cs`) para que
   puedas probar la migración de inmediato
