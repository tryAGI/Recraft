dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://external.api.recraft.ai/doc/spec/api.yaml
autosdk generate openapi.yaml \
  --namespace Recraft \
  --clientClassName RecraftClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://external.api.recraft.ai \
  --security-scheme Http:Header:Bearer
