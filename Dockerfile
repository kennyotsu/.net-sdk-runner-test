FROM mcr.microsoft.com/dotnet/framework/sdk:4.8.1

WORKDIR /app

COPY . .

RUN msbuild . /p:Configuration=Release /m

# Прежде чем начать сборку:
# - Переключите Docker Engine в режим контейнеров Windows

# Начните сборку и запуск:
# docker build -t lastdock .
# docker run -it lastdock
# c:/app/bin/Release/LastDock.exe