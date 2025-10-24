# Modular Cloud Build (single trigger, selectable targets)

This repo contains a **single** Cloud Build config (`cloudbuild.yaml`) that can deploy multiple components, controlled via the `_TARGETS` substitution.

## Components
- `frontend`
- `backend`
- `gitea`
- `confluence`
- `jira`

> Current version is **safe**: each step is a placeholder (`echo`). It will **not fail** if some components are not yet ready. Replace the placeholder blocks with real build/deploy logic when you are ready.

## How it works

- Your UI / orchestrator calls the trigger with a substitution like:
  - `_TARGETS=frontend,backend`
  - `_TARGETS=gitea`
  - `_TARGETS=frontend,backend,gitea`
- The pipeline runs only the matching steps.

## Cloud Build trigger

- Keep your trigger pointing at **cloudbuild.yaml** (root of the repo).
- Make sure the trigger passes `_TARGETS` (your orchestrator already does this).

## Customization

Replace the placeholder sections with your real commands (docker build/push, gcloud run deploy, helm install, terraform apply, etc.).
