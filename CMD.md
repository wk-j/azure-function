## Instructions

```bash
npm install -g azure-functions-core-tools@core
func init .

func new

dotnet build src/WkFunctions
dotnet publish src/WkFunctions --output ../../publish

func start --script-root publish
```