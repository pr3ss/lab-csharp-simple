using System.Security.Cryptography;

namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        public string Seed { get; private set; }
        public string Name { get; private set; }
        public int Ordinal { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            Name = name;
            Ordinal = ordinal;
            Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }



        /// <inheritdoc cref="object.ToString"/>
        public override string ToString() => $"{this.GetType().Name}(Name={Name}, Seed={Seed}, Ordinal={Ordinal})";
        

        // TODO generate Equals(object obj)
        public override bool Equals(object obj) => (((Card)obj).Name.Equals(Name) && ((Card)obj).Seed.Equals(Seed)) ? true : false;
        
        // TODO generate GetHashCode()
        public override  int GetHashCode() => (Name + Seed + Ordinal.ToString()).GetHashCode();
        
        
    }
}
