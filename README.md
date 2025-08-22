# To.Notification.KafkaEvents

События, потребляемые микросервисом Notification.

## Настройка CI/CD

Этот проект использует GitHub Actions для автоматической сборки и публикации NuGet пакетов в GitHub Packages.

### Необходимые секреты

Для работы CI/CD pipeline **дополнительная настройка секретов не требуется**. GitHub Actions автоматически предоставляет `GITHUB_TOKEN` для публикации в GitHub Packages.

### Настройка публикации

**GitHub Packages**:
- Пакеты автоматически публикуются в GitHub Packages при создании тега
- Используется встроенный `GITHUB_TOKEN`
- Пакеты доступны по адресу: `https://github.com/{owner}/{repo}/packages`

### Запуск публикации

Для публикации новой версии пакета:

1. Обновите версию в `ToNotificationKafkaEvents.csproj`
2. Создайте и запушьте тег:
   ```bash
   git tag v1.2.2
   git push origin v1.2.2
   ```

### Использование пакета

Для использования пакета в других проектах добавьте источник GitHub Packages:

```bash
dotnet nuget add source https://nuget.pkg.github.com/{owner}/index.json \
  --name github \
  --username {username} \
  --password {github_token} \
  --store-password-in-clear-text
```

Или добавьте в `nuget.config`:

```xml
<packageSources>
  <add key="github" value="https://nuget.pkg.github.com/{owner}/index.json" />
</packageSources>
```

### Локальная разработка

```bash
# Восстановление зависимостей
dotnet restore

# Сборка
dotnet build

# Создание пакета
dotnet pack -c Release

# Тестирование
dotnet test
```