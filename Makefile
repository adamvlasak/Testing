hub:
	docker-compose down
	docker-compose up -d --remove-orphans

clean:
	dotnet clean

build:
	dotnet build

test:
	dotnet test