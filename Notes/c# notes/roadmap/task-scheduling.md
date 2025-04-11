# Task Scheduling - Detailed Guide

## Native Background Service
### Implementation
- IHostedService
  - Lifetime Management
  - Startup/Shutdown
  - Error Handling
- BackgroundService
  - ExecuteAsync
  - Cancellation
  - Periodic Tasks
- Scoped Services
  - Service Factory
  - Scope Management
  - Resource Cleanup

## Hangfire
### Core Features
- Job Types
  - Fire-and-Forget
  - Delayed Jobs
  - Recurring Jobs
  - Continuations
- Storage Options
  - SQL Server
  - Redis
  - MongoDB
- Monitoring
  - Dashboard
  - Performance Metrics
  - Error Handling

## Quartz.NET
### Scheduling
- Job Definition
  - Job Interface
  - Job Data Map
  - Job Factory
- Trigger Types
  - Simple Triggers
  - Cron Triggers
  - Calendar Integration
- Advanced Features
  - Job Listeners
  - Trigger Listeners
  - Scheduler Listeners

### Enterprise Features
- Clustering
  - Job Store Options
  - Load Balancing
  - Failover
- Persistence
  - ADO.NET Job Store
  - Serialization
  - Recovery
