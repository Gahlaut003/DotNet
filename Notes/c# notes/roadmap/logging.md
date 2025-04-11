# Logging Frameworks - Detailed Guide

## Serilog
### Basic Configuration
- Application Setup
  - Package Installation
  - Minimal Configuration
  - Common Patterns
- Log Levels
  - Verbose/Debug/Information
  - Warning/Error/Fatal
  - Level Switching

### Sink Configuration
- File Sinks
  - Rolling Files
  - JSON Formatting
  - File Size Limits
- Database Sinks
  - SQL Server
  - PostgreSQL
  - MongoDB
- Cloud Sinks
  - Azure App Insights
  - AWS CloudWatch
  - Elasticsearch

### Advanced Features
- Enrichment
  - Property Enrichers
  - Context Enrichers
  - Custom Enrichers
- Structured Logging
  - Message Templates
  - Semantic Information
  - Custom Value Formatters
- Performance
  - Async Writing
  - Buffering
  - Batching

## NLog
### Configuration
- Layout Renderers
  - Built-in Renderers
  - Custom Renderers
  - Nested Renderers
- Targets
  - File Target
  - Database Target
  - Network Target
  - Custom Targets

### Advanced Features
- Routing Rules
  - Filters
  - Conditions
  - Final Rules
- Async Processing
  - Buffer Size
  - Queue Limits
  - Overflow Actions
- Layout Optimization
  - Caching
  - Compile-time Rendering
  - Memory Management
