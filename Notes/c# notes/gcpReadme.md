┌──────────────────────────────────────────────────────────────────────────────┐
│                                1️⃣ Compute                                   │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Cloud Functions                                                           │
│    ├─ What: Event-driven serverless compute                                 │
│    ├─ Type: Functions-as-a-Service (FaaS)                                   │
│    ├─ Does: Runs lightweight code in response to events                     │
│    └─ Why: Great for automation, microservices, no infra to manage          │
│                                                                              │
│2. App Engine                                                                │
│    ├─ What: Fully managed application platform                              │
│    ├─ Type: Platform-as-a-Service (PaaS)                                    │
│    ├─ Does: Deploys web apps with built-in scaling                          │
│    └─ Why: Simplifies deployment and operations                             │
│                                                                              │
│3. Cloud Run                                                                 │
│    ├─ What: Serverless for containerized workloads                          │
│    ├─ Type: Containers-as-a-Service (CaaS)                                  │
│    ├─ Does: Runs stateless containers triggered by HTTP requests            │
│    └─ Why: Serverless + portability with Docker containers                  │
│                                                                              │
│4. Google Kubernetes Engine (GKE)                                            │
│    ├─ What: Managed Kubernetes service                                      │
│    ├─ Type: Container orchestration                                         │
│    ├─ Does: Deploys and manages Kubernetes clusters                         │
│    └─ Why: Scalable, production-ready container orchestration               │
│                                                                              │
│5. Compute Engine                                                            │
│    ├─ What: Infrastructure-as-a-Service VMs                                 │
│    ├─ Type: IaaS with VMs, GPUs, TPUs, SSDs                                 │
│    ├─ Does: Runs virtual machines with custom OS/images                     │
│    └─ Why: Full control for advanced workloads                              │
│                                                                              │
│6. Bare Metal Solution                                                       │
│    ├─ What: Physical servers for high-performance apps                      │
│    ├─ Type: Bare-metal as-a-service                                         │
│    ├─ Does: Offers direct access to hardware for specialized needs          │
│    └─ Why: Ideal for low-latency or licensed workloads                      │
│                                                                              │
│7. Preemptible VMs                                                           │
│    ├─ What: Short-lived, low-cost VMs                                       │
│    ├─ Type: Spot-like virtual machines                                      │
│    ├─ Does: Runs batch jobs with 24-hour lifespan or less                   │
│    └─ Why: Cost-efficient for fault-tolerant tasks                          │
│                                                                              │
│8. Shielded VMs                                                              │
│    ├─ What: Secure virtual machines with integrity checks                   │
│    ├─ Type: Hardened VMs on Compute Engine                                  │
│    ├─ Does: Protects against rootkits, bootkits, tampering                  │
│    └─ Why: Enhanced security for sensitive workloads                        │
│                                                                              │
│9. Sole-tenant Nodes                                                         │
│    ├─ What: Single-tenant physical servers                                  │
│    ├─ Type: Dedicated hardware                                               │
│    ├─ Does: Runs VMs isolated to one customer                               │
│    └─ Why: Regulatory compliance and workload isolation                     │
│                                                                              │
│10. VMware Engine                                                            │
│    ├─ What: Fully managed VMware in Google Cloud                            │
│    ├─ Type: Hybrid cloud infrastructure                                     │
│    ├─ Does: Migrates on-prem VMware to cloud with minimal changes           │
│    └─ Why: Seamless migration of enterprise VMware workloads                │
└──────────────────────────────────────────────────────────────────────────────┘


┌──────────────────────────────────────────────────────────────────────────────┐
│                                2️⃣ Storage                                   │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Cloud Filestore                                                           │
│    ├─ What: Fully managed NFS file server                                   │
│    ├─ Type: Network File System (NFS)                                       │
│    ├─ Does: Provides shared file storage over standard NFS                  │
│    └─ Why: Ideal for apps needing POSIX-compliant file access               │
│                                                                              │
│2. Cloud Storage                                                             │
│    ├─ What: Global, multi-class object storage                              │
│    ├─ Type: Object storage (Standard, Nearline, Coldline, Archive)          │
│    ├─ Does: Stores unstructured data like images, backups, logs             │
│    └─ Why: Durable, highly available, ideal for static content and backups  │
│                                                                              │
│3. Persistent Disk                                                           │
│    ├─ What: Durable block storage for VMs                                   │
│    ├─ Type: Standard and SSD-backed block storage                           │
│    ├─ Does: Attachable disks for Compute Engine VMs                         │
│    └─ Why: Reliable and auto-replicated storage for critical workloads      │
│                                                                              │
│4. Local SSD                                                                 │
│    ├─ What: High-speed SSDs physically attached to VM hosts                 │
│    ├─ Type: Ephemeral block storage                                         │
│    ├─ Does: Offers ultra-low latency and high IOPS                          │
│    └─ Why: Best for caching and temp data needing blazing-fast access       │
└──────────────────────────────────────────────────────────────────────────────┘


┌──────────────────────────────────────────────────────────────────────────────┐
│                                3️⃣ Database                                  │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Cloud Bigtable                                                            │
│    ├─ What: NoSQL wide-column database for massive scale                    │
│    ├─ Type: Non-relational (NoSQL)                                          │
│    ├─ Does: Handles billions of rows, ideal for time-series/IoT             │
│    └─ Why: Petabyte-scale with low latency and high throughput              │
│                                                                              │
│2. Cloud Firestore                                                           │
│    ├─ What: Serverless document-oriented database                           │
│    ├─ Type: NoSQL (document-based)                                          │
│    ├─ Does: Real-time syncing across apps and users                         │
│    └─ Why: Great for mobile/web apps with dynamic data                      │
│                                                                              │
│3. Cloud Memorystore                                                         │
│    ├─ What: In-memory data store                                            │
│    ├─ Type: Redis or Memcached                                              │
│    ├─ Does: Caches data for fast retrieval                                  │
│    └─ Why: Reduces latency and improves app performance                     │
│                                                                              │
│4. Cloud Spanner                                                             │
│    ├─ What: Distributed SQL database with global transactions               │
│    ├─ Type: Relational + horizontal scaling                                 │
│    ├─ Does: Combines SQL structure with NoSQL-like scalability              │
│    └─ Why: Strong consistency with infinite scaling                         │
│                                                                              │
│5. Cloud SQL                                                                 │
│    ├─ What: Managed SQL databases                                           │
│    ├─ Type: MySQL, PostgreSQL, SQL Server                                   │
│    ├─ Does: Handles backups, replication, patching                          │
│    └─ Why: Eases management of traditional RDBMSs                           │
│                                                                              │
│6. Database Migration Service                                                │
│    ├─ What: Data migration tool for databases                               │
│    ├─ Type: Fully managed service                                           │
│    ├─ Does: Migrates to Cloud SQL or AlloyDB                                │
│    └─ Why: Streamlines database modernization                               │
│                                                                              │
│7. Cloud SQL Insights                                                        │
│    ├─ What: Query analytics and monitoring                                  │
│    ├─ Type: SQL performance insights tool                                   │
│    ├─ Does: Visualizes slow queries and detects issues                      │
│    └─ Why: Optimizes performance and troubleshooting                        │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                4️⃣ Data Analytics                            │
├──────────────────────────────────────────────────────────────────────────────┤
│1. BigQuery                                                                  │
│    ├─ What: Fully managed data warehouse                                    │
│    ├─ Type: Columnar SQL-based analytics engine                             │
│    ├─ Does: Analyzes huge datasets using SQL                                │
│    └─ Why: Real-time insights at massive scale                              │
│                                                                              │
│2. BigQuery BI Engine                                                        │
│    ├─ What: In-memory analytics layer                                       │
│    ├─ Type: Accelerator for BigQuery                                        │
│    ├─ Does: Speeds up dashboards and visualizations                         │
│    └─ Why: Enhances BI tool performance like Looker/Tableau                 │
│                                                                              │
│3. BigQuery ML                                                               │
│    ├─ What: ML built into BigQuery                                          │
│    ├─ Type: SQL-based machine learning                                      │
│    ├─ Does: Trains and deploys ML models using SQL                          │
│    └─ Why: Democratizes ML for data analysts                                │
│                                                                              │
│4. BigQuery GIS                                                              │
│    ├─ What: Geospatial data analysis in BigQuery                            │
│    ├─ Type: GIS + SQL integration                                           │
│    ├─ Does: Queries location-based datasets                                 │
│    └─ Why: Spatial intelligence for analytics                               │
│                                                                              │
│5. Cloud Composer                                                            │
│    ├─ What: Workflow orchestration (based on Apache Airflow)               │
│    ├─ Type: Managed data pipeline service                                   │
│    ├─ Does: Automates and manages complex workflows                         │
│    └─ Why: Coordinates multi-step data and ML processes                     │
│                                                                              │
│6. Dataflow                                                                  │
│    ├─ What: Unified batch and stream processing                             │
│    ├─ Type: Apache Beam-powered service                                     │
│    ├─ Does: Processes real-time and historical data                         │
│    └─ Why: Flexible, serverless data pipeline for ETL/ELT                   │
│                                                                              │
│7. Dataproc                                                                  │
│    ├─ What: Managed Spark and Hadoop clusters                               │
│    ├─ Type: Big data ecosystem service                                      │
│    ├─ Does: Runs open-source jobs like Hive, Pig, Spark                     │
│    └─ Why: Simplifies lift-and-shift of on-prem Hadoop                      │
│                                                                              │
│8. Pub/Sub                                                                   │
│    ├─ What: Messaging service for event ingestion                           │
│    ├─ Type: Publisher/subscriber (asynchronous)                             │
│    ├─ Does: Connects services with real-time messaging                      │
│    └─ Why: Enables event-driven systems and stream processing               │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                5️⃣ Hybrid and Multi-cloud                    │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Anthos                                                                    │
│    ├─ What: Multi-cloud Kubernetes and service management                   │
│    ├─ Type: Hybrid and multi-cloud platform                                 │
│    ├─ Does: Runs and manages apps anywhere (cloud/on-prem)                  │
│    └─ Why: Unified operations across hybrid cloud                           │
│                                                                              │
│2. Anthos Clusters                                                           │
│    ├─ What: Managed GKE for hybrid environments                             │
│    ├─ Type: On-premises or edge GKE                                         │
│    ├─ Does: Delivers consistent Kubernetes across locations                 │
│    └─ Why: Flexibility and portability of Kubernetes                        │
│                                                                              │
│3. Anthos Config Management                                                  │
│    ├─ What: Centralized policy enforcement                                  │
│    ├─ Type: Config as code and GitOps                                       │
│    ├─ Does: Syncs configs and enforces policies across clusters             │
│    └─ Why: Ensures governance and security at scale                         │
│                                                                              │
│4. Anthos Service Mesh                                                       │
│    ├─ What: Managed Istio for Anthos                                        │
│    ├─ Type: Secure microservice communication mesh                          │
│    ├─ Does: Observes, secures, controls service-to-service traffic          │
│    └─ Why: Built-in observability, security, and resilience                 │
│                                                                              │
│5. Cloud Run for Anthos                                                      │
│    ├─ What: Serverless containers on Anthos                                 │
│    ├─ Type: Anthos-integrated Cloud Run                                     │
│    ├─ Does: Runs serverless apps in hybrid environments                     │
│    └─ Why: Brings serverless to your own infrastructure                     │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                6️⃣ AI and ML                                 │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Vertex AI                                                                 │
│    ├─ Managed platform for ML                                               │
│    └─ End-to-end ML lifecycle                                               │
│                                                                              │
│2. AutoML                                                                    │
│    ├─ Custom low-code models                                                │
│    └─ Simplified ML model creation                                          │
│                                                                              │
│3. Vertex AI Data Labeling                                                   │
│    ├─ Data labeling by humans                                               │
│    └─ Simplified data preparation                                           │
│                                                                              │
│4. Deep Learning VM Images                                                   │
│    ├─ Preconfigured VMs for deep learning                                   │
│    └─ Optimized for AI workloads                                            │
│                                                                              │
│5. Vertex AI Workbench                                                       │
│    ├─ Jupyter-based environment for Data Science                            │
│    └─ Integrated development environment                                    │
│                                                                              │
│6. Deep Learning Containers                                                  │
│    ├─ Preconfigured containers for deep learning                            │
│    └─ Simplified deployment                                                 │
│                                                                              │
│7. Vertex AI Matching Engine                                                 │
│    ├─ Vector similarity searches                                            │
│    └─ High-performance retrieval                                            │
│                                                                              │
│8. Vertex AI Pipelines                                                       │
│    ├─ Hosted ML workflows                                                   │
│    └─ Simplified pipeline management                                        │
│                                                                              │
│9. Vertex AI Predictions                                                     │
│    ├─ Autoscaled model serving                                              │
│    └─ Reliable and scalable                                                 │
│                                                                              │
│10. Vertex AI Training                                                       │
│    ├─ Distributed AI training                                               │
│    └─ Optimized for large-scale models                                      │
│                                                                              │
│11. Vertex AI Edge Manager                                                   │
│    ├─ Deploy and monitor edge inferences                                    │
│    └─ Simplified edge AI management                                         │
│                                                                              │
│12. Vertex Explainable AI                                                    │
│    ├─ Understand ML model predictions                                       │
│    └─ Enhanced interpretability                                             │
│                                                                              │
│13. Vertex AI Feature Store                                                  │
│    ├─ Managed ML feature repository                                         │
│    └─ Centralized feature management                                        │
│                                                                              │
│14. Vertex ML Metadata                                                       │
│    ├─ Artifact, lineage, and execution tracking                             │
│    └─ Simplified experiment management                                      │
│                                                                              │
│15. Vertex AI Model Monitoring                                               │
│    ├─ Monitor models for skew/drift                                         │
│    └─ Enhanced reliability                                                  │
│                                                                              │
│16. Vertex AI Tensorboard                                                    │
│    ├─ Managed TensorBoard for ML-experiment visualization                   │
│    └─ Simplified experiment tracking                                        │
│                                                                              │
│17. Vertex AI Vizier                                                         │
│    ├─ Black-box hyperparameter tuning                                       │
│    └─ Optimized model performance                                           │
│                                                                              │
│18. Speech-To-Text                                                           │
│    ├─ Convert audio to text                                                 │
│    └─ High accuracy                                                         │
│                                                                              │
│19. Talent Solutions                                                         │
│    ├─ Job search with ML                                                    │
│    └─ Enhanced recruitment                                                  │
│                                                                              │
│20. Text-To-Speech                                                           │
│    ├─ Convert text to audio                                                 │
│    └─ Natural-sounding voices                                               │
│                                                                              │
│21. Cloud TPU                                                                │
│    ├─ Hardware acceleration for ML                                          │
│    └─ Optimized for AI workloads                                            │
│                                                                              │
│22. Cloud Translation                                                        │
│    ├─ Language detection and translation                                    │
│    └─ Supports multiple languages                                           │
│                                                                              │
│23. Cloud Video Intelligence API                                             │
│    ├─ Scene-level video annotation                                          │
│    └─ Simplified video analysis                                             │
│                                                                              │
│24. Cloud Vision                                                             │
│    ├─ Image recognition and classification                                  │
│    └─ Pre-trained ML models                                                 │
│                                                                              │
│25. Contact Center AI                                                        │
│    ├─ AI in your contact center                                             │
│    └─ Enhanced customer support                                             │
│                                                                              │
│26. Dialogflow                                                               │
│    ├─ Create conversational interfaces                                      │
│    └─ Natural language understanding                                        │
│                                                                              │
│27. Document AI                                                              │
│    ├─ Analyze, classify, search documents                                   │
│    └─ Simplified document processing                                        │
│                                                                              │
│28. Recommendations AI                                                      │
│    ├─ Create custom recommendations                                         │
│    └─ Enhanced personalization                                              │
│                                                                              │
│29. Vision Product Search                                                    │
│    ├─ Visual search for products                                            │
│    └─ Simplified product discovery                                          │
└──────────────────────────────────────────────────────────────────────────────┘

┌──────────────────────────────────────────────────────────────────────────────┐
│                                7️⃣ Networking                                │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Carrier Peering                                                           │
│    ├─ What: Connectivity through supported service providers                │
│    ├─ Type: Hybrid connectivity                                              │
│    └─ Why: Enables customers to access Google services with reduced latency │
│                                                                              │
│2. Direct Peering                                                            │
│    ├─ What: Direct interconnection with Google’s edge network               │
│    ├─ Type: Network peering                                                  │
│    └─ Why: Offers low-latency, high-throughput access to Google services    │
│                                                                              │
│3. Dedicated Interconnect                                                    │
│    ├─ What: Dedicated private physical connection to Google                 │
│    ├─ Type: High-bandwidth hybrid connectivity                              │
│    └─ Why: Ensures consistent and secure enterprise-grade networking        │
│                                                                              │
│4. Partner Interconnect                                                      │
│    ├─ What: Connectivity via Googles service provider partners             │
│    ├─ Type: Flexible hybrid network                                          │
│    └─ Why: Extends private network to Google Cloud without dedicated fiber  │
│                                                                              │
│5. Google Cloud Armor                                                        │
│    ├─ What: DDoS protection and Web App Firewall                            │
│    ├─ Type: Network security service                                         │
│    └─ Why: Protects workloads from internet threats                         │
│                                                                              │
│6. Cloud CDN                                                                 │
│    ├─ What: Content delivery network                                        │
│    ├─ Type: Global caching service                                           │
│    └─ Why: Reduces latency and improves web/app performance                 │
│                                                                              │
│7. Cloud DNS                                                                 │
│    ├─ What: Programmable and scalable DNS resolution                        │
│    ├─ Type: Managed authoritative DNS                                        │
│    └─ Why: Provides high-performance domain resolution                      │
│                                                                              │
│8. Cloud Load Balancing                                                      │
│    ├─ What: Global/multi-region load distribution                           │
│    ├─ Type: External/internal load balancer                                 │
│    └─ Why: Delivers high availability and performance for applications      │
│                                                                              │
│9. Cloud NAT                                                                 │
│    ├─ What: Managed Network Address Translation                             │
│    ├─ Type: Outbound internet gateway for private VMs                       │
│    └─ Why: Enables secure outbound internet access without public IPs      │
│                                                                              │
│10. Cloud Router                                                             │
│    ├─ What: Dynamic BGP route exchange with on-prem                         │
│    ├─ Type: Virtual router                                                   │
│    └─ Why: Enables hybrid network communication with route intelligence     │
│                                                                              │
│11. Cloud VPN                                                                │
│    ├─ What: Encrypted IPsec tunnels to on-prem                              │
│    ├─ Type: Site-to-site VPN                                                 │
│    └─ Why: Extends on-prem network securely to GCP                          │
│                                                                              │
│12. Network Service Tiers                                                    │
│    ├─ What: Pricing tiers for network performance                           │
│    ├─ Type: Premium and Standard tiers                                       │
│    └─ Why: Choose between cost or performance-driven routing                │
│                                                                              │
│13. Network Telemetry                                                        │
│    ├─ What: Network observability tools                                     │
│    ├─ Type: Monitoring and insights                                          │
│    └─ Why: Offers visibility into network performance and issues            │
│                                                                              │
│14. Traffic Director                                                         │
│    ├─ What: Service mesh control plane                                      │
│    ├─ Type: Load balancer for microservices                                 │
│    └─ Why: Provides policy-based routing and observability for services     │
│                                                                              │
│15. Anthos Service Mesh                                                      │
│    ├─ What: Secure service-to-service communication                        │
│    ├─ Type: Managed Istio-based service mesh                                │
│    └─ Why: Enables fine-grained security and traffic control                │
│                                                                              │
│16. Virtual Private Cloud (VPC)                                              │
│    ├─ What: Software-defined global private network                         │
│    ├─ Type: Logical isolation of resources                                   │
│    └─ Why: Organizes and secures resources within isolated IP ranges        │
│                                                                              │
│17. Cloud Domains                                                            │
│    ├─ What: Domain registration and management                              │
│    ├─ Type: Domain registrar and DNS management                             │
│    └─ Why: Simplifies handling of domain life cycle                         │
│                                                                              │
│18. VPC Service Controls                                                     │
│    ├─ What: Security boundaries for services                                │
│    ├─ Type: Context-aware perimeter policies                                 │
│    └─ Why: Prevents data exfiltration between services                      │
│                                                                              │
│19. Network Intelligence Center                                              │
│    ├─ What: Visual tools for network analysis                               │
│    ├─ Type: Monitoring, diagnostics, and forecasting                         │
│    └─ Why: Helps troubleshoot and optimize network configurations           │
│                                                                              │
│20. Service Directory                                                        │
│    ├─ What: Central registry for services                                   │
│    ├─ Type: Service discovery platform                                       │
│    └─ Why: Simplifies discovery and connection of services at scale         │
│                                                                              │
│21. Private Service Connect                                                  │
│    ├─ What: Private and secure service publishing/consumption               │
│    ├─ Type: VPC-level endpoint routing                                       │
│    └─ Why: Connect services across orgs/VPCs without exposing to internet   │
│                                                                              │
│22. Network Connectivity Center                                              │
│    ├─ What: Central hub for hybrid network connectivity                     │
│    ├─ Type: Hub-and-spoke topology orchestration                            │
│    └─ Why: Simplifies hybrid/multi-cloud network operations                 │
│                                                                              │
│23. Packet Mirroring                                                         │
│    ├─ What: Mirror VM network traffic                                       │
│    ├─ Type: Deep packet inspection and forensics tool                        │
│    └─ Why: Enables intrusion detection and packet analysis                  │
│                                                                              │
│24. Cloud IDS                                                                │
│    ├─ What: Intrusion detection system                                      │
│    ├─ Type: Managed threat detection                                         │
│    └─ Why: Detects and alerts on network-based threats                      │
└──────────────────────────────────────────────────────────────────────────────┘
┌──────────────────────────────────────────────────────────────────────────────┐
│                            8️⃣ Identity and Security                         │
├──────────────────────────────────────────────────────────────────────────────┤
│1. Access Transparency                                                       │
│    ├─ What: Provides visibility into actions taken by Google staff          │
│    ├─ Type: Audit logging service                                           │
│    ├─ Does: Logs and reports Google personnels access to your content      │
│    └─ Why: Enhances trust and compliance by auditing provider access        │
│                                                                              │
│2. Assured Workloads                                                         │
│    ├─ What: Configures secure environments for compliance requirements      │
│    ├─ Type: Compliance management service                                   │
│    ├─ Does: Applies security controls to meet regulatory standards          │
│    └─ Why: Simplifies adherence to industry and government regulations      │
│                                                                              │
│3. Binary Authorization                                                      │
│    ├─ What: Enforces deploy-time security policies for containers           │
│    ├─ Type: Deployment security control                                     │
│    ├─ Does: Ensures only trusted container images are deployed              │
│    └─ Why: Protects Kubernetes environments from unverified code            │
│                                                                              │
│4. Certificate Authority Service                                             │
│    ├─ What: Managed service for private certificate authorities             │
│    ├─ Type: Certificate management service                                  │
│    ├─ Does: Simplifies deployment and management of private CAs             │
│    └─ Why: Enables secure certificate issuance without infrastructure       │
│                                                                              │
│5. Cloud Asset Inventory                                                     │
│    ├─ What: Central repository for cloud resource metadata                  │
│    ├─ Type: Asset management service                                        │
│    ├─ Does: Aggregates and monitors metadata of cloud assets                │
│    └─ Why: Provides visibility and control over cloud resources             │
│                                                                              │
│6. Cloud Audit Logs                                                          │
│    ├─ What: Maintains logs of activities in Google Cloud services           │
│    ├─ Type: Audit logging service                                           │
│    ├─ Does: Records admin and data access events                            │
│    └─ Why: Facilitates security analysis and compliance auditing            │
│                                                                              │
│7. Cloud Data Loss Prevention (DLP)                                          │
│    ├─ What: Detects and protects sensitive data                             │
│    ├─ Type: Data protection service                                         │
│    ├─ Does: Inspects and masks sensitive information                        │
│    └─ Why: Prevents exposure of confidential data                           │
│                                                                              │
│8. Cloud HSM                                                                 │
│    ├─ What: Hardware Security Module service                                │
│    ├─ Type: Managed cryptographic key service                               │
│    ├─ Does: Provides FIPS 140-2 Level 3 certified key management            │
│    └─ Why: Ensures high-assurance encryption key protection                 │
│                                                                              │
│9. Cloud External Key Manager (EKM)                                          │
│    ├─ What: Manages encryption keys outside Google Cloud                    │
│    ├─ Type: External key management service                                 │
│    ├─ Does: Integrates external keys with cloud services                    │
│    └─ Why: Maintains separation of duties and compliance                    │
│                                                                              │
│10. Cloud IAM                                                                │
│    ├─ What: Manages access to cloud resources                               │
│    ├─ Type: Identity and Access Management                                  │
│    ├─ Does: Controls who can take action on resources                       │
│    └─ Why: Ensures appropriate access and security                          │
│                                                                              │
│11. Cloud Identity                                                           │
│    ├─ What: Identity as a Service (IDaaS) solution                          │
│    ├─ Type: Identity management platform                                    │
│    ├─ Does: Manages users, devices, and apps centrally                      │
│    └─ Why: Simplifies identity and access management                        │
│                                                                              │
│12. Cloud Identity-Aware Proxy                                               │
│    ├─ What: Controls access to applications based on identity               │
│    ├─ Type: Application-level access control                                │
│    ├─ Does: Verifies user identity before granting app access               │
│    └─ Why: Enhances security beyond network perimeter                       │
│                                                                              │
│13. Cloud Key Management Service                                             │
│    ├─ What: Manages cryptographic keys for cloud services                   │
│    ├─ Type: Key management service                                          │
│    ├─ Does: Creates, uses, and rotates encryption keys                      │
│    └─ Why: Protects data with centralized key control                       │
│                                                                              │
│14. Resource Manager                                                         │
│    ├─ What: Manages cloud resource containers                               │
│    ├─ Type: Resource hierarchy service                                      │
│    ├─ Does: Organizes projects and policies hierarchically                  │
│    └─ Why: Facilitates governance and access control                        │
│                                                                              │
│15. Security Command Center                                                  │
│    ├─ What: Security and risk management platform                           │
│    ├─ Type: Security monitoring service                                     │
│    ├─ Does: Detects vulnerabilities and threats                             │
│    └─ Why: Provides centralized security visibility                         │
│                                                                              │
│16. Web Security Scanner                                                     │
│    ├─ What: Scans web applications for vulnerabilities                      │
│    ├─ Type: Application security testing tool                               │
│    ├─ Does: Identifies common web app security issues                       │
│    └─ Why: Helps remediate potential exploits                               │
│                                                                              │
│17. Confidential Computing                                                   │
│    ├─ What: Encrypts data during processing                                 │
│    ├─ Type: In-use data protection                                          │
│    ├─ Does: Keeps data encrypted in memory                                  │
│    └─ Why: Protects sensitive data during computation                       │
│                                                                              │
│18. Access Context Manager                                                   │
│    ├─ What: Defines attribute-based access control                          │
│    ├─ Type: Context-aware access service                                    │
│    ├─ Does: Sets access levels based on user attributes                     │
│    └─ Why: Enables fine-grained access policies                             │
│                                                                              │
│19. Event Threat Detection                                                   │
│    ├─ What: Monitors for suspicious activity                                │
│    ├─ Type: Threat detection service                                        │
│    ├─ Does: Scans logs/events for malicious behavior                        │
│    └─ Why: Identifies threats in real-time to reduce risk                   │
│                                                                              │
│20. Managed Service for Microsoft Active Directory                           │
│    ├─ What: Managed version of Microsoft AD in the cloud                    │
│    ├─ Type: Directory service                                               │
│    ├─ Does: Supports Windows workloads and identity federation              │
│    └─ Why: Simplifies AD operations in hybrid environments                  │
│                                                                              │
│21. Secret Manager                                                           │
│    ├─ What: Secure storage for API keys, passwords, and certificates        │
│    ├─ Type: Secret management service                                       │
│    ├─ Does: Stores, rotates, and manages secrets centrally                  │
│    └─ Why: Protects sensitive application credentials                       │
│                                                                              │
│22. Security Key Enforcement                                                 │
│    ├─ What: Enforces 2-step verification with hardware keys                 │
│    ├─ Type: Authentication policy control                                   │
│    ├─ Does: Requires use of security keys for account access                │
│    └─ Why: Prevents account takeover attacks                                │
│                                                                              │
│23. Shielded VMs                                                             │
│    ├─ What: Hardened virtual machines with secure boot                      │
│    ├─ Type: Secure VM instance                                              │
│    ├─ Does: Protects against rootkits and boot-level malware                │
│    └─ Why: Increases confidence in VM integrity                            │
│                                                                              │
│24. Titan Security Key                                                       │
│    ├─ What: Google’s hardware-based 2FA device                              │
│    ├─ Type: Physical security token                                         │
│    ├─ Does: Provides phishing-resistant login protection                    │
│    └─ Why: Secures access to sensitive user and admin accounts              │
│                                                                              │
│25. VPC Service Controls                                                     │
│    ├─ What: Defines service perimeters for GCP APIs                         │
│    ├─ Type: Access boundary security feature                                │
│    ├─ Does: Restricts data movement across services                         │
│    └─ Why: Mitigates data exfiltration and insider risks                    │
│                                                                              │
│26. Chronicle                                                                │
│    ├─ What: Security analytics and threat detection platform                │
│    ├─ Type: Cloud-native SIEM                                               │
│    ├─ Does: Correlates logs and telemetry for threats                       │
│    └─ Why: Speeds up incident response with advanced insights               │
│                                                                              │
│27. VirusTotal                                                               │
│    ├─ What: Malware and URL scanning service                                │
│    ├─ Type: Threat intelligence platform                                    │
│    ├─ Does: Aggregates virus and malware detection from many engines        │
│    └─ Why: Helps investigate and detect threats early                       │
│                                                                              │
│28. Risk Manager                                                             │
│    ├─ What: Security risk assessment tool                                   │
│    ├─ Type: Risk posture evaluation service                                 │
│    ├─ Does: Assesses controls and security health across resources          │
│    └─ Why: Helps organizations prioritize security improvements             │
│                                                                              │
│29. reCAPTCHA Enterprise                                                     │
│    ├─ What: Advanced bot and abuse protection                               │
│    ├─ Type: CAPTCHA and risk analysis tool                                  │
│    ├─ Does: Differentiates humans from bots using behavioral signals        │
│    └─ Why: Protects sites from fraud, abuse, and automated attacks          │
│                                                                              │
│30. BeyondCorp Enterprise                                                    │
│    ├─ What: Zero-trust access security model                                │
│    ├─ Type: Identity and context-based access framework                     │
│    ├─ Does: Grants access based on user and device trustworthiness          │
│    └─ Why: Secures work from anywhere with no VPN dependency                │
└──────────────────────────────────────────────────────────────────────────────┘
