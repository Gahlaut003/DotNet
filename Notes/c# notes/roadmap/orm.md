# Object Relational Mapping (ORM) - Detailed Guide

## Entity Framework Core
### Code First + Migrations
- Model Configuration
  - Data Annotations
  - Fluent API
  - Relationships
  - Indexes and Keys
- Migration Management
  - Creating Migrations
  - Applying Migrations
  - Rolling Back
  - Custom Operations

### Loading Strategies
- Lazy Loading
  - Proxy Generation
  - Navigation Properties
  - Performance Implications
- Eager Loading
  - Include()
  - ThenInclude()
  - Multiple Paths
- Explicit Loading
  - Load()
  - Collection()
  - Reference()

### Change Tracker API
- Entity States
  - Added/Modified/Deleted
  - Detached/Unchanged
- Change Detection
  - AutoDetectChanges
  - ChangeTracker Events
- Performance Optimization
  - No-Tracking Queries
  - Bulk Operations
  - Batching

## Dapper
- Basic Operations
  - Query/QueryAsync
  - Execute/ExecuteAsync
  - QueryMultiple
- Advanced Features
  - Custom Type Mapping
  - Multi-Mapping
  - Dynamic Parameters
- Best Practices
  - Connection Management
  - Parameter Handling
  - Performance Tips

## RepoDB
- CRUD Operations
  - Insert/Update/Delete
  - Merge Operations
  - Batch Processing
- Advanced Features
  - Caching
  - Tracing
  - Type Mapping
- Extensions
  - PostgreSQL
  - SQLite
  - MySQL

## NHibernate
- Configuration
  - XML Mapping
  - Fluent Mapping
  - Conventions
- Session Management
  - ISession
  - IStatelessSession
  - Transactions
- Advanced Features
  - Caching
  - Interceptors
  - Events
