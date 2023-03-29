# Event Sourcing with CQRS

.Net 6 Event Sourcing implementation with Kafka, Entity Framework Core and PostgreSQL. Commands and Queries are separated based on project. (Project based separation implementation of CQRS)

## Write API (Command Project)

Project domain is a simple Todo Domain. There is my own Event Store implementation. Command project executes following use-case operations.

- **Create Todo**
- **Update Title**
- **Update Content**
- **Change Status**
- **Complete Todo**

### Implementations

- Onion Architecture
- Entity Framework Core - PostgreSQL
- Outbox Pattern
- MediatR
- DbContextHandler

## Outbox Worker (Worker Service)

Reads Command Project's Outbox table and Produces messages for Read API to consume. (There can be many consumers.)

### Implementations

- Worker Service
- Dapper
- Confluent Kafka


## Read API (Query Project)

This project consumes messages and projects to its own database. (MongoDB) Every query project can create its own read model. 
In this project i have worked on same data model with command project.

### Implementations

- Onion Architecture
- MongoDB
- Confluent Kafka
- Worker Service
- MediatR