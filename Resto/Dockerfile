FROM mcr.microsoft.com/dotnet/core/aspnet:3.0

WORKDIR /webapp

COPY /webapp /webapp

EXPOSE 5001

ENV ASPNETCORE_URLS https://*:5001

ENTRYPOINT ["dotnet", "Resto.dll"]
