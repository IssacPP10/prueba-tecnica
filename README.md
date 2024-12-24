# 📝 **Prueba Técnica** 🚀

Este proyecto es una prueba técnica que incluye tanto una **aplicación web** como una **API** desarrollada específicamente para esta prueba.

## 🔧 **Lenguajes y Frameworks Utilizados**:
- **Lenguaje**: C#
- **Framework**: .NET 6.0

## 📦 **Librerías**:
- **Newtonsoft.Json**: Para manejar la serialización y deserialización de JSON.
- **Bootstrap**: Para diseño responsivo y estilizado.
- **jQuery**: Para manipulación del DOM.
- **jQuery Validation**: Para validaciones del lado del cliente.

## 🏗️ **Estructura del Proyecto**:

```plaintext
PruebaTecnica/
├── Controllers/               # Controladores de la API
│   └── FallaController.cs     
├── Models/                    # Modelos de datos
│   ├── ErrorViewModel.cs      
│   ├── Falla.cs               
│   └── FallaConsulta.cs       
├── Services/                  # Servicios relacionados a la lógica de negocio
├── Views/                     # Vistas para la aplicación web
├── wwwroot/                   # Archivos estáticos
│   ├── css/                   # Hojas de estilo
│   ├── js/                    # Archivos JavaScript
│   └── lib/                   # Librerías de terceros
├── appsettings.json           # Configuraciones de la aplicación
├── Program.cs                 # Configuración principal de la aplicación
├── PruebaTecnica.csproj       # Proyecto de .NET
└── PruebaTecnica.sln          # Solución de Visual Studio
```

## 🌐 **API**:
Este proyecto incluye una **API** desarrollada específicamente para gestionar las operaciones relacionadas con las entidades del proyecto. Puedes realizar operaciones CRUD para las entidades que maneja el sistema.

## 🚀 **Instrucciones para Ejecutar el Proyecto**:

1. **Clona el repositorio**:

   ```bash
   git clone https://github.com/tu_usuario/PruebaTecnica.git
   ```

2. **Navega al directorio del proyecto**:

   ```bash
   cd PruebaTecnica
   ```

3. **Restaura las dependencias**:

   ```bash
   dotnet restore
   ```

4. **Ejecuta el proyecto**:

   ```bash
   dotnet run
   ```

   La aplicación estará disponible en `http://localhost:5000` (o el puerto configurado).

## 📜 **Licencia**:
Este proyecto está bajo la **Licencia MIT**. Si deseas contribuir o utilizar este código, por favor revisa los términos de la licencia.
