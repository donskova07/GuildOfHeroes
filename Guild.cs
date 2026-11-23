public class Guild {
    public string Name { get; private set; }
    private List<Hero> _heroes = new List<Hero>();

    public int MemberCount {
        get { return _heroes.Count; }
    }

    public Guild(string name) {
        Name = name;
    }

    public bool AddHero(Hero hero) {
        if (FindHeroByName(hero.Name) != null) {
            return false;
        }

        _heroes.Add(hero);
        return true;
    }

    public Hero? FindHeroByName(string searchName) {
        if (string.IsNullOrWhiteSpace(searchName)) {
            return null;
        }

        string normalized = searchName.Trim();

        foreach (Hero hero in _heroes) {
            if (string.Equals(hero.Name, normalized, StringComparison.OrdinalIgnoreCase)) {
                return hero;
            }
        }

        return null;
    }

    public bool RemoveHero(string searchName) {
        Hero? hero = FindHeroByName(searchName);
        if (hero == null) {
            return false;
        }

        _heroes.Remove(hero);
        return true;
    }

    public List<Hero> GetMembers() {
        List<Hero> result = new List<Hero>();
        foreach (Hero hero in _heroes) {
            result.Add(hero);
        }
        return result;
    }

    public int CountHealthy(int minimum) {
        int count = 0;

        foreach (Hero hero in _heroes) {
            if (hero.Health >= minimum) {
                count += 1;
            }
        }

        return count;
    }

    public Hero? FindStrongest() {
        if (_heroes.Count == 0) {
            return null;
        }

        Hero best = _heroes[0];
        foreach (Hero hero in _heroes) {
            if (hero.Health > best.Health) {
                best = hero;
            }
        }

        return best;
    }
}
