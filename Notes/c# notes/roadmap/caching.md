# Caching - Detailed Guide

## Memory Cache
### Cache Options
- Expiration Policies
  - Absolute
  - Sliding
  - Custom
- Size Limits
  - Entry Count
  - Memory Size
  - Compact Policies

### Implementation
- IMemoryCache Interface
  - Get/Set Operations
  - Remove Operations
  - TryGetValue Pattern
- Cache Entry Options
  - Priority Levels
  - Callbacks
  - Dependencies

## Distributed Cache
### Redis Implementation
- Data Types
  - Strings
  - Lists
  - Sets
  - Sorted Sets
  - Hashes
- Advanced Features
  - Pub/Sub
  - Lua Scripting
  - Transactions
  - Pipeline
- Clustering
  - Master-Replica
  - Redis Sentinel
  - Redis Cluster
- Persistence
  - RDB
  - AOF
  - Hybrid

### Memcached Implementation
- Architecture
  - Key Distribution
  - Consistent Hashing
  - Replication
- Operations
  - Get/Set
  - Add/Replace
  - Increment/Decrement
- Advanced Features
  - Binary Protocol
  - Connection Pooling
  - Authentication
