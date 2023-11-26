FROM mcr.microsoft.com/dotnet/framework/sdk:4.8.1

WORKDIR /app

COPY . .

RUN msbuild . /p:Configuration=Release /m

# ������ ��� ������ ������:
# - ����������� Docker Engine � ����� ����������� Windows

# ������� ������ � ������:
# docker build -t lastdock .
# docker run -it lastdock
# c:/app/bin/Release/LastDock.exe