# Dependency Injection - Detailed Guide

## Scrutor
### Assembly Scanning
- Registration by Convention
  - Interface Matching
  - Type Filtering
  - Multiple Interfaces
- Decoration Patterns
  - Single Decorator
  - Multiple Decorators
  - Conditional Decoration

## Life Cycles
### Scoped
- Request Lifetime Management
  - Scope Creation
  - Disposal Timing
  - Nested Scopes
- Common Use Cases
  - DbContext
  - Identity Services
  - Request-specific Services

### Transient
- Memory Management
  - Resource Usage
  - Disposal Patterns
  - Memory Leaks
- Implementation Guidelines
  - When to Use
  - Performance Impact
  - Anti-patterns

### Singleton
- Thread Safety
  - Synchronization
  - Immutability
  - Lock Patterns
- State Management
  - Concurrent Access
  - Data Sharing
  - Memory Considerations

## DI Containers
### Microsoft.Extensions
- Service Collection
  - Registration Methods
  - Service Descriptors
  - Factory Methods
- Configuration Integration
  - Options Pattern
  - Named Options
  - Validation
- Lifetime Management
  - Scope Validation
  - Disposal
  - Root Container

### AutoFac
- Module System
  - Registration Modules
  - Assembly Scanning
  - Generic Services
- Advanced Features
  - Interceptors
  - Decorators
  - Child Containers
- Integration
  - ASP.NET Core
  - Generic Hosting
  - Legacy Systems
