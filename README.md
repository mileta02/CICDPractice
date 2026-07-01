# CICDPractice

A simple ASP.NET Core Web API Calculator project built to practice CI/CD principles using GitHub Actions, Docker, and Render.com.

---

## Tech Stack

| | Technology | Role |
|---|---|---|
| 🟦 | .NET 10 | Web API framework |
| 🐳 | Docker | Containerization |
| ⚙️ | GitHub Actions | CI/CD pipeline |
| 📦 | Docker Hub | Container registry |
| ☁️ | Render.com | Cloud hosting |

---

## CI/CD Pipeline

Every push to `master` triggers the following pipeline:

```
Restore deps → Build → Run tests → Docker push → Deploy to Render
```

```yaml
# .github/workflows/ci.yml (overview)
1. Restore NuGet dependencies
2. Build the project
3. Run xUnit tests
4. Build & push Docker image to Docker Hub
5. Trigger redeploy on Render.com via deploy hook
```

> The pipeline is the point of this project, a full automated path from code push to live deployment.
