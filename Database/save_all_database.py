import subprocess
import os
from pathlib import Path

# --- CONFIGURATION ---

# Chemins vers mysqldump et mysql
MYSQLDUMP = r"C:\wamp64\bin\mysql\mysql9.5.0\bin\mysqldump.exe"
MYSQL = r"C:\wamp64\bin\mysql\mysql9.5.0\bin\mysql.exe"

# Connexion MySQL
MYSQL_USER = "root"
MYSQL_PASSWORD = ""
MYSQL_HOST = "localhost"
MYSQL_PORT = "3306"

# Répertoire de sauvegarde : répertoire du script + "backup_sauvegarde"
SCRIPT_DIR = Path(__file__).resolve().parent
BACKUP_DIR = SCRIPT_DIR / "backup_sauvegarde"

# ---------------------------------------------

def check_paths():
    if not Path(MYSQLDUMP).exists():
        print(f"ERREUR : Le fichier {MYSQLDUMP} n'existe pas !")
        input("Appuyez sur une touche pour quitter...")
        exit(1)

    if not BACKUP_DIR.exists():
        BACKUP_DIR.mkdir(parents=True)
        print(f"Répertoire créé : {BACKUP_DIR}")


def get_databases():
    """Retourne la liste des bases à sauvegarder."""
    
    cmd = [
        MYSQL,
        "-u", MYSQL_USER,
        "-h", MYSQL_HOST,
        "--port", MYSQL_PORT,
        "-N", "-e",
        (
            "SELECT SCHEMA_NAME FROM information_schema.SCHEMATA "
            "WHERE SCHEMA_NAME NOT IN "
            "('information_schema','performance_schema','mysql','sys');"
        )
    ]

    result = subprocess.run(cmd, capture_output=True, text=True)

    if result.returncode != 0:
        print("Erreur lors de la récupération des bases :", result.stderr)
        exit(1)

    return result.stdout.strip().split("\n")


def backup_database(dbname):
    """Sauvegarde une base MySQL dans un fichier .sql"""
    backup_file = BACKUP_DIR / f"{dbname}.sql"

    cmd = [
        MYSQLDUMP,
        "-u", MYSQL_USER,
        "-h", MYSQL_HOST,
        "--port=" + MYSQL_PORT,
        "--databases",
        "--add-drop-database",
        "--routines=true",
        "--single-transaction",     
        "--set-gtid-purged=OFF",  
        dbname,
        "-r", str(backup_file)
    ]

    process = subprocess.run(cmd)

    if process.returncode == 0 and backup_file.exists():
        print(f"[OK] Base {dbname} sauvegardée -> {backup_file}")
    else:
        print(f"[ERREUR] Échec sauvegarde : {dbname}")


def main():
    print("=== Sauvegarde MySQL ===")

    check_paths()
    databases = get_databases()

    if not databases:
        print("Aucune base à sauvegarder.")
        return

    print(f"{len(databases)} bases trouvées : {databases}\n")

    for db in databases:
        backup_database(db)

    print("\nTerminé.")
    input("Appuyez sur une touche pour quitter...")


if __name__ == "__main__":
    main()
