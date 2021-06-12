PARALLEL_OPTIONS=-- NUnit.NumberOfTestWorkers=4
UI_PROJECT=UI/UI.csproj

all: hub clean build test-parallel

hub:
	docker compose down
	docker compose up -d --remove-orphans

log:
	docker-compose logs -f --tail=10

clean:
	pwsh cleanup.ps1

build: format
	dotnet build

format:
	dotnet-format

test:
	dotnet test

test-parallel:
	dotnet test ${PARALLEL_OPTIONS}

smoke:
	dotnet test ${UI_PROJECT} --filter TestCategory=smoke

smoke-parallel:
	dotnet test ${UI_PROJECT} --filter TestCategory=smoke ${PARALLEL_OPTIONS}

login:
	dotnet test ${UI_PROJECT} --filter TestCategory=login

login-parallel:
	dotnet test ${UI_PROJECT} --filter TestCategory=login ${PARALLEL_OPTIONS}

lesson:
	dotnet test ${UI_PROJECT} --filter TestCategory=lesson

lesson-parallel:
	dotnet test ${UI_PROJECT} --filter TestCategory=lesson ${PARALLEL_OPTIONS}

.PHONY: doc
doc:
	docfx doc/docfx.json

doc-serve:
	docfx doc/docfx.json --serve -p 8081

kill:
	taskkill /f /im chromedriver.exe /fi "STATUS ne RUNNING"
	taskkill /f /im chrome.exe
