# mask-ggj

Jeu Unity realise pour la Global Game Jam.

## Prerequis
- Unity 6000.3.5f2 (exact version recommandee)
- Unity Hub pour ouvrir le projet

## Recreer et lancer le jeu depuis les sources
1. Ouvrir le projet avec Unity Hub en selectionnant le dossier racine.
2. Attendre l import des packages (URP 2D, Input System, etc).
3. Ouvrir la scene principale `Assets/Scenes/Level01.unity`.
4. Cliquer sur Play pour lancer.

## Controls (par defaut)
- Deplacement: fleches gauche/droite ou A/D (axe Horizontal Unity)
- Saut: Space (bouton Jump Unity)

## Build
1. Ouvrir File > Build Settings.
2. Verifier que les scenes suivantes sont cochees:
   - `Assets/Scenes/Level01.unity`
   - `Assets/Scenes/level2.unity`
   - `Assets/Scenes/End.unity`
3. Choisir la plateforme cible puis Build.

## Notes
- La scene `Assets/Scenes/Level1.unity` est desactivee dans les Build Settings.
