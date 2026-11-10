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

## Roadmap

- [ ] Phase 0: Git and GitHub workflow
- [ ] Phase 1: .NET 10 API with EF Core, DI, async and tests
- [ ] Phase 2: Docker and docker-compose
- [ ] Phase 2.5: Legacy integration with CoreWCF and gRPC
- [ ] Phase 3: CI/CD with GitHub Actions
- [ ] Phase 4: First AI agent with the Claude API
- [ ] Phase 5: Multi-agent system over RabbitMQ
- [ ] Phase 6: Kubernetes and Helm
- [ ] Phase 7: Observability and polish

## TFVC to Git

| TFVC | Git |
| --- | --- |
| Workspace | `git clone` (local copy of the repo) |
| Get Latest | `git pull` |
| Pending Changes | `git status`, `git diff` |
| Check-in | `git commit` + `git push` |
| Changeset | Commit |
| View History | `git log` |
| Shelveset | `git stash` (local only), or a pushed branch + PR (shared, for review) |
| Branch (server folder) | `git switch -c <branch>` (a pointer, not a folder) |
| Undo Pending Changes | `git restore <file>` |
| Annotate | `git blame <file>` |
| Rollback | `git revert <commit>` |
