using System.Text;

public abstract class TranslatorBase
{
    protected abstract Dictionary<string, string> Dictionary { get; }

    public void Translate(string rawText)
    {
        char[ ] punctuation = { ',', '.', '?', '!' };
        StringBuilder sb = new();

        List<string> splitText = rawText.Split(' ').ToList();

        foreach (var key in splitText)
        {
            if (key.Any(c => punctuation.Contains(c)))
            {
                if (Dictionary.TryGetValue(key.Trim(punctuation), out string value))
                {
                    sb.Append(AppendPunctuation(value, key.Last()));
                }
                else
                {
                    sb.Append(AppendPunctuation(key, '('));
                }
            }
            else if (Dictionary.TryGetValue(key, out string value))
            {
                sb.Append(' ').Append(value);
            }
            else
            {
                sb.Append(AppendPunctuation(key, '('));
            }
        }

        Console.WriteLine(sb.ToString().TrimStart(' '));
    }

    protected string AppendPunctuation(string word, char punctuation) =>
        punctuation.Equals('(') 
                    ? $" ({word})" 
                    : $" {word}{punctuation}";
}

public class SpanishDictionary : TranslatorBase
{
    protected override Dictionary<string, string> Dictionary { get; } = new(StringComparer.OrdinalIgnoreCase)
    {
        // Pronouns
        { "I", "Yo" },
        { "You", "Tú" },
        { "He", "Él" },
        { "She", "Ella" },
        { "We", "Nosotros" },
        { "They", "Ellos" },

        // Possessives
        { "My", "Mi" },
        { "Your", "Tu" },

        // Verbs
        { "Be", "Estar" },
        { "Have", "Tener" },
        { "Go", "Ir" },
        { "See", "Ver" },
        { "Eat", "Comer" },
        { "Speak", "Hablar" },
        { "Live", "Vivir" },
        { "Like", "Gustar" },
        { "Do", "Hacer" },
        { "Doing", "Haciendo" },
        { "Going", "Yendo" },
        { "Take", "Tomar" },
        { "Im", "Estoy" },
        { "Am", "Soy" },
        { "Get", "Obtener" },
        { "Might", "Podría" },

        // Nouns
        { "Friend", "Amigo" },
        { "Family", "Familia" },
        { "House", "Casa" },
        { "Car", "Coche" },
        { "Book", "Libro" },
        { "Table", "Mesa" },
        { "Chair", "Silla" },
        { "Door", "Puerta" },
        { "Window", "Ventana" },
        { "Phone", "Teléfono" },
        { "Day", "Día" },
        { "Night", "Noche" },
        { "Morning", "Mañana" },
        { "Week", "Semana" },
        { "Year", "Año" },
        { "School", "Escuela" },
        { "Work", "Trabajo" },
        { "Sun", "Sol" },
        { "Moon", "Luna" },
        { "Water", "Agua" },
        { "Fire", "Fuego" },
        { "Tree", "Árbol" },
        { "Flower", "Flor" },
        { "Name", "Nombre" },
        { "Store", "Tienda" },

        // Adjectives
        { "Cold", "Frío" },
        { "Warm", "Caliente" },

        // Articles, conjunctions, greetings
        { "Is", "Es" },
        { "Are", "Son" },
        { "A", "Un" },
        { "And", "Y" },
        { "Hello", "Hola" },
        { "Hi", "Hola" },
        { "What", "Qué" },
        { "Here", "Aquí" },
        { "To", "A" },
        { "Too", "También" },
        { "On", "En" },
        { "The", "El" },
        { "Or", "O" }
    };
}

public class FrenchDictionary : TranslatorBase
{
    protected override Dictionary<string, string> Dictionary { get; } = new(StringComparer.OrdinalIgnoreCase)
    {
        // Pronouns
        { "I", "Je" },
        { "You", "Tu" },
        { "He", "Il" },
        { "She", "Elle" },
        { "We", "Nous" },
        { "They", "Ils" },

        // Possessives
        { "My", "Mon" },
        { "Your", "Ton" },

        // Verbs
        { "Be", "Être" },
        { "Have", "Avoir" },
        { "Go", "Aller" },
        { "See", "Voir" },
        { "Eat", "Manger" },
        { "Speak", "Parler" },
        { "Live", "Vivre" },
        { "Like", "Aimer" },
        { "Do", "Faire" },
        { "Doing", "Faisant" },
        { "Going", "Allant" },
        { "Take", "Prendre" },
        { "Im", "Suis" },
        { "Am", "Suis" },
        { "Get", "Obtenir" },
        { "Might", "Pourrait" },

        // Nouns
        { "Friend", "Ami" },
        { "Family", "Famille" },
        { "House", "Maison" },
        { "Car", "Voiture" },
        { "Book", "Livre" },
        { "Table", "Table" },
        { "Chair", "Chaise" },
        { "Door", "Porte" },
        { "Window", "Fenêtre" },
        { "Phone", "Téléphone" },
        { "Day", "Jour" },
        { "Night", "Nuit" },
        { "Morning", "Matin" },
        { "Week", "Semaine" },
        { "Year", "Année" },
        { "School", "École" },
        { "Work", "Travail" },
        { "Sun", "Soleil" },
        { "Moon", "Lune" },
        { "Water", "Eau" },
        { "Fire", "Feu" },
        { "Tree", "Arbre" },
        { "Flower", "Fleur" },
        { "Name", "Nom" },
        { "Store", "Magasin" },

        // Adjectives
        { "Cold", "Froid" },
        { "Warm", "Chaud" },

        // Articles, conjunctions, greetings
        { "Is", "Est" },
        { "Are", "Sont" },
        { "A", "Un" },
        { "And", "Et" },
        { "Hello", "Bonjour" },
        { "Hi", "Salut" },
        { "What", "Quoi" },
        { "Here", "Ici" },
        { "To", "À" },
        { "Too", "Aussi" },
        { "On", "Sur" },
        { "The", "Le" },
        { "Or", "Ou" }
    };
}
