using Microsoft.Extensions.Localization;
using MudBlazor;
public class RuMudLocalizer : MudLocalizer
{
	private Dictionary<string, string> _localization;
	public RuMudLocalizer()
	{
		_localization = new()
		{
			{ "MudDataGrid.AddFilter", "Добавить фильтр" },
			{ "MudDataGrid.Apply", "Применить" },
			{ "MudDataGrid.Cancel", "Отменить" },
			{ "MudDataGrid.Clear", "Очистить" },
			{ "MudDataGrid.CollapseAllGroups", "Свернуть все группы" },
			{ "MudDataGrid.Column", "Колонка" },
			{ "MudDataGrid.Columns", "Колонки" },
			{ "MudDataGrid.contains", "содержит" },
			{ "MudDataGrid.ends with", "оканчивается на" },
			{ "MudDataGrid.equals", "равно" },
			{ "MudDataGrid.ExpandAllGroups", "Развернуть все группы" },
			{ "MudDataGrid.Filter", "Фильтр" },
			{ "MudDataGrid.False", "Неверно" },
			{ "MudDataGrid.FilterValue", "Значение фильтра" },
			{ "MudDataGrid.Group", "Группа" },
			{ "MudDataGrid.Hide", "Скрыть" },
			{ "MudDataGrid.HideAll", "Скрыть все" },
			{ "MudDataGrid.is", "равен" },
			{ "MudDataGrid.is after", "после" },
			{ "MudDataGrid.is before", "до" },
			{ "MudDataGrid.is empty", "пустой" },
			{ "MudDataGrid.is not", "не" },
			{ "MudDataGrid.is not empty", "не пустой" },
			{ "MudDataGrid.is on or after", "равен или после" },
			{ "MudDataGrid.is on or before", "равен или до" },
			{ "MudDataGrid.not contains", "не содержит" },
			{ "MudDataGrid.not equals", "не равно" },
			{ "MudDataGrid.Operator", "Оператор" },
			{ "MudDataGrid.RefreshData", "Обновить данные" },
			{ "MudDataGrid.Save", "Сохранить" },
			{ "MudDataGrid.ShowAll", "Показать все" },
			{ "MudDataGrid.starts with", "начинается с" },
			{ "MudDataGrid.True", "Верно" },
			{ "MudDataGrid.Ungroup", "Разгруппировать" },
			{ "MudDataGrid.Unsort", "Рассортировать" },
			{ "MudDataGrid.Value", "Значение" }
		};
	}

	public override LocalizedString this[string key]
	{
		get
		{
			var currentCulture = Thread.CurrentThread.CurrentUICulture.Parent.TwoLetterISOLanguageName;
			if (currentCulture.Equals("ru", StringComparison.InvariantCultureIgnoreCase)
				&& _localization.TryGetValue(key, out var res))
			{
				return new(key, res);
			}
			else
			{
				return new(key, key, true);
			}
		}
	}
}