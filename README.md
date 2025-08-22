# To.Notification.KafkaEvents

События, потребляемые микросервисом Notification.

## Настройка CI/CD

Этот проект использует GitHub Actions для автоматической сборки и публикации NuGet пакетов.

### Необходимые секреты

Для работы CI/CD pipeline вам нужно настроить следующие секреты в настройках репозитория (Settings → Secrets and variables → Actions):

#### Обязательные секреты:
- **GITHUB_TOKEN** - автоматически предоставляется GitHub Actions, дополнительная настройка не требуется

#### Дополнительные секреты (если нужно публиковать в другие реестры):
- **NUGET_API_KEY** - API ключ для публикации в nuget.org
- **NUGET_SOURCE_URL** - URL источника NuGet (например, для приватного реестра)

### Настройка публикации

1. **GitHub Packages** (по умолчанию):
   - Пакеты автоматически публикуются в GitHub Packages при создании тега
   - Используется встроенный `GITHUB_TOKEN`

2. **NuGet.org** (опционально):
   - Добавьте секрет `NUGET_API_KEY` с вашим API ключом от nuget.org
   - Раскомментируйте соответствующий шаг в `.github/workflows/ci.yml`

3. **Приватный реестр** (опционально):
   - Добавьте секреты `NUGET_API_KEY` и `NUGET_SOURCE_URL`
   - Раскомментируйте соответствующий шаг в `.github/workflows/ci.yml`

### Запуск публикации

Для публикации новой версии пакета:

1. Обновите версию в `ToNotificationKafkaEvents.csproj`
2. Создайте и запушьте тег:
   ```bash
   git tag v1.2.2
   git push origin v1.2.2
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