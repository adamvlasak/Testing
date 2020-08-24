all: hub clean build test-parallel

hub:
	docker-compose down
	docker-compose up -d --remove-orphans

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
