using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloning_Cats_924
{
    /// <summary>
    /// Represents a cat with a name, owner, and number of lives.
    /// </summary>
    public class Cat
    {
        public string Name;
        public int NumberOfLives;
        public bool isBad;
        public Owner Owner;

        /// <summary>
        /// Creates a cat from a <paramref name="name"/> and <paramref name="numberOfLives"/> provided.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numberOfLives"></param>
        public Cat(string name, int numberOfLives)
        {
            Name = name;
            NumberOfLives = numberOfLives;
            isBad = false;
        }

        /// <summary>
        /// Creates a cat with a given <paramref name="name"/> and nine lives. 
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name)
        {
            Name = name;
            NumberOfLives = 9;
            isBad = false;
        }

        public Cat()
        {
            Name = "";
            NumberOfLives = 9;
            isBad = false;
        }

        /// <summary>
        /// Creates a cat with a given <paramref name="name"/> and <paramref name="owner"/>. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        public Cat(string name, Owner owner)
        {
            Name = name;
            NumberOfLives = 9;
            Owner = owner;
            isBad = false;
        }

        /// <summary>
        /// Changes the name of our cat to a <paramref name="name"/> provided.
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Outputs the name of our cat.
        /// </summary>
        /// <returns>The name property of our cat object.</returns>
        public string GetName()
        {
            return Name;
        }

        /// <summary>
        /// Subtracts <paramref name="livesToLose"/> from the cat's total lives.
        /// </summary>
        /// <param name="livesToLose"></param>
        public void Die(int livesToLose)
        {
            NumberOfLives -= livesToLose;
        }

        public Cat ShallowClone()
        {
            return (Cat)this.MemberwiseClone();
        }

        public Cat DeepClone()
        {
            return new Cat() {
                Name = this.Name,
                NumberOfLives = this.NumberOfLives,
                isBad = this.isBad,
                Owner = this.Owner.DeepClone()
            };
        }
    }
}
