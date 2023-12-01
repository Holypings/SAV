import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Date;

public class fenetre {
    // Déclaration des variables pour stocker les données
    private static String nom;
    private static String prenom;
    private static String telephone;
    private static String etat;
    private static String mail;
    private static String sujet;
    private static String commentaire;
    private static Date date;

    public static void main(String[] args) {
        JFrame frame = new JFrame("Fenetre");
        frame.setSize(600, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JPanel panel = new JPanel();
        panel.setLayout(new GridLayout(0, 2));

        JLabel nomLabel = new JLabel("Nom:");
        JTextField nomField = new JTextField(10); // Réduire la taille à 10 colonnes
        JLabel prenomLabel = new JLabel("Prénom:");
        JTextField prenomField = new JTextField(10);
        JLabel telephoneLabel = new JLabel("Téléphone:");
        JTextField telephoneField = new JTextField(10);
        JLabel etatLabel = new JLabel("État:");
        String[] options = {"Bon état", "Passable", "Mauvais état"};
        JComboBox<String> etatComboBox = new JComboBox<>(options);
        JLabel mailLabel = new JLabel("Mail:");
        JTextField mailField = new JTextField(10);
        JLabel sujetLabel = new JLabel("Sujet:");
        JTextField sujetField = new JTextField(10);
        JLabel commentaireLabel = new JLabel("Commentaire:");
        JTextField commentaireField = new JTextField(10);

        JButton envoyerButton = new JButton("Envoyer");
        JButton supprimerButton = new JButton("Supprimer");

        // Création du modèle de table
        DefaultTableModel tableModel = new DefaultTableModel();
        String[] columnNames = {"Nom", "Prénom", "Téléphone", "État", "Mail", "Sujet", "Commentaire", "Date"};
        tableModel.setColumnIdentifiers(columnNames);

        // Création de la table
        JTable table = new JTable(tableModel);
        JScrollPane scrollPane = new JScrollPane(table);

        envoyerButton.addActionListener(e -> {
            // Récupération des données et stockage dans les variables
            nom = nomField.getText();
            prenom = prenomField.getText();
            telephone = telephoneField.getText();
            etat = (String) etatComboBox.getSelectedItem();
            mail = mailField.getText();
            sujet = sujetField.getText();
            commentaire = commentaireField.getText();
            date = new Date();

            // Connexion à la base de données et insertion des données
            try {
                Connection connexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/sav", "root", "");

                // Insérer dans la table "user"
                String userQuery = "INSERT INTO user (nom, prenom, telephone, mail) VALUES (?, ?, ?, ?)";
                PreparedStatement userStatement = connexion.prepareStatement(userQuery);
                userStatement.setString(1, nom);
                userStatement.setString(2, prenom);
                userStatement.setString(3, telephone);
                userStatement.setString(4, mail);
                userStatement.executeUpdate();
                userStatement.close();

                // Insérer dans la table "requete"
                String requeteQuery = "INSERT INTO requete (sujet, commentaire, date, mail) VALUES (?, ?, ?, ?)";
                PreparedStatement requeteStatement = connexion.prepareStatement(requeteQuery);
                requeteStatement.setString(1, sujet);
                requeteStatement.setString(2, commentaire);
                requeteStatement.setDate(3, new java.sql.Date(date.getTime()));
                requeteStatement.setString(4, mail);
                requeteStatement.executeUpdate();
                requeteStatement.close();

                // Insérer dans la table "produit"
                String produitQuery = "INSERT INTO produit (etatRepare) VALUES (?)";
                PreparedStatement produitStatement = connexion.prepareStatement(produitQuery);
                produitStatement.setString(1, etat);
                produitStatement.executeUpdate();
                produitStatement.close();

                System.out.println("Données insérées avec succès dans la base de données.");

                // Fermeture de la connexion
                connexion.close();
            } catch (SQLException ex) {
                ex.printStackTrace();
            }

            // Ajout des données à la table
            tableModel.addRow(new Object[]{nom, prenom, telephone, etat, mail, sujet, commentaire, date});

            // Réinitialisation des champs
            nomField.setText("");
            prenomField.setText("");
            telephoneField.setText("");
            etatComboBox.setSelectedIndex(0);
            mailField.setText("");
            sujetField.setText("");
            commentaireField.setText("");
        });

        supprimerButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int selectedRow = table.getSelectedRow();
                if (selectedRow != -1) {
                    tableModel.removeRow(selectedRow);
                }
            }
        });

        panel.add(nomLabel);
        panel.add(nomField);
        panel.add(prenomLabel);
        panel.add(prenomField);
        panel.add(telephoneLabel);
        panel.add(telephoneField);
        panel.add(etatLabel);
        panel.add(etatComboBox);
        panel.add(mailLabel);
        panel.add(mailField);
        panel.add(sujetLabel);
        panel.add(sujetField);
        panel.add(commentaireLabel);
        panel.add(commentaireField);
        panel.add(envoyerButton);
        panel.add(supprimerButton);

        frame.add(panel, BorderLayout.NORTH);
        frame.add(scrollPane, BorderLayout.CENTER);
        frame.setVisible(true);
    }
}
