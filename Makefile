all: hub clean build test-parallel

hub:
	docker-compose down
	docker-compose up -d --remove-orphans

clean:
	dotnet clean

build:
	dotnet build

format:
	dotnet-format

test:
	dotnet test

test-parallel:
	dotnet test -- NUnit.NumberOfTestWorkers=2
