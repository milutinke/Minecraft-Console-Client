# syntax=docker/dockerfile:1

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy source
COPY . .

# Restore and publish
RUN dotnet restore MinecraftClient/MinecraftClient.csproj -r linux-x64
RUN dotnet publish MinecraftClient/MinecraftClient.csproj -c Release -r linux-x64 -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS runtime
WORKDIR /app

# Create non-root user (handle existing GID 1000)
RUN groupadd -g 1000 appgroup 2>/dev/null || groupadd appgroup && \
    useradd -u 1000 -g appgroup -s /bin/bash -m appuser 2>/dev/null || useradd -g appgroup -s /bin/bash -m appuser

# Copy published app
COPY --from=build /app/publish .

# Set ownership and user
RUN chown -R appuser:appgroup /app
USER appuser

# Entry point (PublishSingleFile=true creates native executable)
ENTRYPOINT ["./MinecraftClient"]