all: hub clean build test-parallel

hub:
	docker-compose down
	docker-compose up -d --remove-orphans

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
	dotnet test -- NUnit.NumberOfTestWorkers=2

.PHONY: doc
doc:
	docfx doc/docfx.json

doc-watch:
	docfx doc/docfx.json --serve -p 8081

kill:
	taskkill /f /im chromedriver.exe /fi "STATUS ne RUNNING"
	taskkill /f /im chrome.exe
