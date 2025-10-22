# hello-build-dotnet
Minimal API (.NET 8) + tests + Docker + Cloud Build

## Local
dotnet test
docker build -t local/hello-build:dev .
docker run -p 8080:8080 -e COMMIT_SHA=local local/hello-build:dev
# GET http://localhost:8080/

## Cloud Build
Vezi cloudbuild.yaml (construiește + împinge în Artifact Registry).
