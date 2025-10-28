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