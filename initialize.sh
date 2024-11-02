dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Recraft \
  RecraftClient \
  https://external.api.recraft.ai/doc/spec/api.yaml \
  tryAGI \
  --output .
