namespace BasicTranslator;

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
