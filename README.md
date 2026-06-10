# Bloom Beauty - Aplicación Móvil .NET MAUI

Una aplicación móvil moderna de comercio electrónico de belleza desarrollada con .NET MAUI y XAML.

## Características

- 🛍️ Catálogo de productos con múltiples categorías
- 🔍 Búsqueda de productos
- ❤️ Lista de favoritos
- 🛒 Carrito de compras funcional
- 👤 Perfil de usuario
- 📱 Diseño responsivo para móviles
- 🎨 Interfaz moderna y atractiva con colores de Bloom Beauty

## Requisitos

- Visual Studio 2022 o posterior
- .NET 8.0 SDK
- MAUI Workload instalado

## Instalación

1. Clona el repositorio
2. Abre la solución en Visual Studio
3. Restaura los paquetes NuGet
4. Compila y ejecuta

## Estructura del Proyecto

```
BloomBeauty/
├── Models/              # Modelos de datos
├── Services/            # Servicios (ProductService, CartService)
├── Views/               # Páginas XAML
├── App.xaml            # Configuración de la aplicación
├── AppShell.xaml       # Shell con navegación
└── MauiProgram.cs      # Configuración de MAUI
```

## Tecnologías

- .NET MAUI 8.0
- XAML para UI
- C# para lógica
- MVVM Toolkit Community

## Desarrollo

El proyecto usa el patrón MVVM con ViewModels y Bindings para mantener el código limpio y separado.

### Agregar nuevas páginas

1. Crear nuevo archivo `.xaml` en la carpeta `Views`
2. Crear el correspondiente `.xaml.cs` code-behind
3. Añadir la ruta en `AppShell.xaml`

## Licencia

© 2025 Bloom Beauty
