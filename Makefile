all: hub clean build test-parallel

hub:
	docker-compose down
	docker-compose up -d --remove-orphans

log:
	docker-compose logs -f --tail=10

clean:
	pwsh cleanup.ps1

build:
	dotnet build

format:
	dotnet-format -v diagnostic

test:
	dotnet test

test-parallel:
	dotnet test -- NUnit.NumberOfTestWorkers=2

.PHONY: doc
doc:
	docfx build doc/docfx.json

doc-watch:
	docfx build doc/docfx.json --serve -p 8081
