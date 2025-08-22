# Руководство по миграции с GitLab CI на GitHub Actions

## Что было сделано

1. **Создан GitHub Actions workflow** (`.github/workflows/ci.yml`):
   - Заменяет функциональность GitLab CI
   - Автоматическая сборка при push в main/master
   - Публикация пакетов в GitHub Packages при создании тегов
   - Использует GitHub Packages вместо GitLab Package Registry

2. **Обновлен файл проекта**:
   - Изменены URL репозитория и проекта на GitHub
   - Сохранена совместимость с .NET 8.0

## Необходимые секреты в GitHub

**Дополнительная настройка секретов не требуется**. GitHub Actions автоматически предоставляет `GITHUB_TOKEN` для публикации в GitHub Packages.

**Важно**: В workflow настроены права доступа `packages: write` для публикации пакетов.

## Настройка

1. Убедитесь, что репозиторий перенесен в GitHub
2. Проверьте, что workflow файл находится в `.github/workflows/ci.yml`
3. Настройка секретов не требуется

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
| `PACKAGE_REGISTRY_PAT` | `GITHUB_TOKEN` (автоматически) |
| GitLab Package Registry | GitHub Packages |
| `CI_API_V4_URL` | Автоматически определяется |
| `CI_PROJECT_ID` | `github.repository_owner` |

## Использование пакета

Для использования пакета в других проектах добавьте источник GitHub Packages:

```bash
dotnet nuget add source https://nuget.pkg.github.com/{owner}/index.json \
  --name github \
  --username {username} \
  --password {github_token} \
  --store-password-in-clear-text
```

## Дополнительные возможности

- **Кэширование зависимостей** - ускорение сборки
- **Матричные сборки** - тестирование на разных версиях .NET
- **Уведомления** - интеграция с Slack, Teams и др.
- **Автоматическое обновление версий** - с помощью GitHub Actions