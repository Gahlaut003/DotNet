# ASP.NET Core Basics - Detailed Guide

## Model-View-Controller (MVC)

### Controllers
- Base Classes
  - Controller
  - ControllerBase
  - Custom base controllers
- Action Methods
  - Parameter binding
  - Return types
  - Async actions
- Filters
  - Authorization
  - Action filters
  - Exception filters
  - Resource filters

### Routing
- Convention-based Routing
  - Route templates
  - Route constraints
  - Optional parameters
- Attribute Routing
  - Route attributes
  - HTTP method attributes
  - Route order
- Advanced Routing
  - Custom route constraints
  - Parameter transformers
  - Endpoint routing

### Model Binding
- Sources
  - Form data
  - Query string
  - Route data
  - Headers
- Custom Model Binding
  - IModelBinder
  - IModelBinderProvider
- Validation
  - Data annotations
  - Custom validation
  - Client-side validation

### Views and ViewComponents
- Razor Syntax
  - Code blocks (@{})
  - Expression syntax (@)
  - HTML encoding
  - Tag Helpers
- Layouts
  - _ViewStart.cshtml
  - _ViewImports.cshtml
  - Sections
  - Partial Views
- ViewComponents
  - Creation and Usage
  - Async ViewComponents
  - Invocation methods
  - Component Results

### Razor Pages
- Page Model
  - Handlers (OnGet, OnPost)
  - Property Binding
  - Model Validation
  - Page Routes
- Advanced Features
  - Custom Conventions
  - Areas in Razor Pages
  - Handler Selection
  - Custom Results
- Best Practices
  - MVVM Pattern
  - Separation of Concerns
  - Performance Optimization
  - Security Considerations

### Middleware
- Built-in Middleware
  - Authentication
  - Authorization
  - Static Files
  - CORS
  - Response Compression
- Custom Middleware
  - Writing Middleware
  - Dependency Injection
  - Order of Execution
  - Branch Pipeline
- Error Handling
  - Developer Exception Page
  - Custom Error Pages
  - Status Code Pages
  - Exception Handlers

### Security
- Authentication
  - Cookie Authentication
  - JWT Bearer
  - OAuth/OpenID Connect
  - Windows Authentication
- Authorization
  - Policy-based
  - Role-based
  - Claims-based
  - Custom Requirements
- Data Protection
  - Key Management
  - Purpose Strings
  - Key Rotation
  - Secure Storage
- Security Headers
  - HTTPS Enforcement
  - HSTS
  - CSP
  - XSS Protection
  - CORS Policies

### Configuration
- Configuration Sources
  - appsettings.json
  - Environment Variables
  - Command Line
  - User Secrets
- Options Pattern
  - IOptions<T>
  - IOptionsSnapshot<T>
  - IOptionsMonitor<T>
  - Custom Options
- Environment-specific
  - Development
  - Staging
  - Production
  - Custom Environments

### Minimal APIs
- Endpoint Definition
  - Route Handlers
  - HTTP Methods
  - Parameters Binding
  - Results
- Advanced Features
  - Filters
  - Authentication
  - Authorization
  - OpenAPI Support
- Best Practices
  - Organization
  - Validation
  - Error Handling
  - Testing

### Performance
- Response Caching
  - Cache Profiles
  - Vary By Headers
  - Cache Busting
- Output Caching
  - Policy Configuration
  - Cache Storage
  - Invalidation
- Response Compression
  - Compression Providers
  - MIME Types
  - Client Support
- Memory Management
  - Object Pooling
  - Memory Cache
  - Response Streaming
  - File Uploads

### Testing
- Unit Testing
  - Controller Tests
  - Middleware Tests
  - Filter Tests
  - Service Tests
- Integration Testing
  - WebApplicationFactory
  - Test Server
  - In-Memory Database
  - Authentication
- Performance Testing
  - Load Testing
  - Stress Testing
  - Benchmarking
  - Profiling
