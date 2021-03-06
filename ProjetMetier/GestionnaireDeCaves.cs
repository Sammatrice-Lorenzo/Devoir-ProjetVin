﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            // A vous de jouer
            LesCaves.Add(unNomDeCave,lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            // A vous de jouer
            int nbBouteilles = 0;
         
           
            if(lesCaves.Keys.Equals(unNomDeCave))
            {
                nbBouteilles = lesCaves.Keys.Count;
            }
        
            

            return nbBouteilles;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            // A vous de jouer
            int nbBouteillesDeRouges = 0;
            int nbBouteilles = NbBouteilles(LesCaves.Keys.ToString());
            
            
            return nbBouteillesDeRouges;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            // A vous de jouer
            return 0;
        }
    }
}
