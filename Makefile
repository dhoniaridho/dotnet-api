run:
	dotnet run
build: 
	dotnet publish -o dist
db-push: 
	dotnet ef database update