import os
import subprocess
from pathlib import Path

# Chemin vers mysql.exe
mysql_path = r"C:\wamp64\bin\mysql\mysql9.5.0\bin\mysql.exe"

# Vérifier si mysql.exe existe
if not os.path.isfile(mysql_path):
    print(f"Le fichier {mysql_path} n'existe pas")
    input("Appuyez sur une touche pour quitter...")
    exit(1)

# Informations de connexion à la base de données
mysql_user = "root"
mysql_password = ""
mysql_host = "localhost"
mysql_port = "3306"

# Répertoire contenant les fichiers .sql → basé sur l'emplacement du script
SCRIPT_DIR = Path(__file__).resolve().parent
backup_dir = SCRIPT_DIR / "backup_sauvegarde"   # 🔥 sous-dossier automatique

# Vérifier si le dossier existe
if not backup_dir.exists() or not backup_dir.is_dir():
    print(f"Le répertoire {backup_dir} n'existe pas")
    input("Appuyez sur une touche pour quitter...")
    exit(1)

# Récupérer tous les fichiers .sql
sql_files = list(backup_dir.glob("*.sql"))

if not sql_files:
    print("Aucun fichier .sql trouvé dans le répertoire de sauvegarde.")
    input("Appuyez sur une touche pour quitter...")
    exit(0)

# Restaurer chaque fichier SQL
for sql_file in sql_files:
    database = sql_file.stem
    print(f"\nRestauration de la base de données {database} en cours...")

    # Commande mysql sans nom de base (le script SQL contient CREATE/USE)
    command = [
        mysql_path,
        f"-u{mysql_user}",
        f"-h{mysql_host}",
        f"--port={mysql_port}"
    ]

    try:
        with open(sql_file, "rb") as f:
            result = subprocess.run(command, stdin=f, stdout=subprocess.PIPE, stderr=subprocess.PIPE)

        if result.returncode == 0:
            print(f"La base de données {database} a été restaurée avec succès ✅")
        else:
            print(f"Une erreur s'est produite lors de la restauration de {database} ❌")
            print(result.stderr.decode())

    except Exception as e:
        print(f"Erreur inattendue lors de la restauration de {database} : {e}")

print("\nRestauration terminée.")
input("Appuyez sur une touche pour quitter...")
