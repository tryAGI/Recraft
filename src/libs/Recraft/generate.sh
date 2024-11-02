dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://external.api.recraft.ai/doc/spec/api.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Recraft \
  --clientClassName RecraftClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations