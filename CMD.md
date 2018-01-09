## Instructions

```bash
npm install -g azure-functions-core-tools@core
func init .

func new

dotnet build src/WkFunctions
dotnet publish src/WkFunctions --output ../../publish/Timer

func start --script-root publish

dotnet publish src/WkHttpTrigger --output ../../publish/Http

# go to publish/Http
func start
func azure login
func azure functionapp publish wk-function
```