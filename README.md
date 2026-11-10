# job-agents

Multi-agent job search system in .NET 10, Docker and Kubernetes.

A system of AI agents that supports a job search. One agent analyzes a job posting and extracts its requirements, a second tailors a CV to the posting, and a third reviews the result and returns feedback. Each agent runs as a separate service, and the agents communicate through a message queue.

Built as a hands-on project to practice modern .NET, containers, CI/CD and multi-agent AI systems.

## Tech stack

- .NET 10, ASP.NET Core Minimal APIs, Entity Framework Core
- PostgreSQL and Redis
- RabbitMQ for agent-to-agent messaging
- Claude API for the AI agents
- CoreWCF and gRPC for legacy integration
- Docker, GitHub Actions and Kubernetes (Helm)
