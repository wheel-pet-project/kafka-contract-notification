# Руководство по миграции с GitLab CI на GitHub Actions

## Что было сделано

1. **Создан GitHub Actions workflow** (`.github/workflows/ci.yml`):
   - Заменяет функциональность GitLab CI
   - Автоматическая сборка при push в main/master
   - Публикация пакетов при создании тегов
   - Использует GitHub Packages вместо GitLab Package Registry

2. **Обновлен файл проекта**:
   - Изменены URL репозитория и проекта на GitHub
   - Сохранена совместимость с .NET 8.0

3. **Создана расширенная версия** (`.github/workflows/ci-extended.yml`):
   - Поддержка публикации в nuget.org
   - Поддержка приватных NuGet реестров
   - Условная публикация в зависимости от наличия секретов

## Необходимые секреты в GitHub

### Для базовой функциональности (GitHub Packages):
- **GITHUB_TOKEN** - автоматически предоставляется, настройка не требуется

### Для публикации в nuget.org:
- **NUGET_API_KEY** - API ключ от nuget.org

### Для приватного реестра:
- **NUGET_API_KEY** - API ключ для приватного реестра
- **NUGET_SOURCE_URL** - URL приватного реестра
- **NUGET_USERNAME** - имя пользователя для приватного реестра

## Настройка секретов

1. Перейдите в настройки репозитория: `Settings → Secrets and variables → Actions`
2. Нажмите `New repository secret`
3. Добавьте необходимые секреты

## Удаление старого GitLab CI

После успешной миграции удалите файл `.gitlab-ci.yml`:

```bash
git rm .gitlab-ci.yml
git commit -m "Remove GitLab CI configuration"
git push
```

## Тестирование

1. Создайте тег для проверки публикации:
   ```bash
   git tag v1.2.2
   git push origin v1.2.2
   ```

2. Проверьте выполнение workflow в GitHub Actions

3. Убедитесь, что пакет опубликован в GitHub Packages

## Отличия от GitLab CI

| GitLab CI | GitHub Actions |
|-----------|----------------|
| `PACKAGE_REGISTRY_PAT` | `GITHUB_TOKEN` |
| GitLab Package Registry | GitHub Packages |
| `CI_API_V4_URL` | Автоматически определяется |
| `CI_PROJECT_ID` | `github.repository_owner` |

## Дополнительные возможности

- **Кэширование зависимостей** - ускорение сборки
- **Матричные сборки** - тестирование на разных версиях .NET
- **Уведомления** - интеграция с Slack, Teams и др.
- **Автоматическое обновление версий** - с помощью GitHub Actions