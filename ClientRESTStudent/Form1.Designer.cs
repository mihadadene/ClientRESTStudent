namespace ClientRESTStudent
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMoy = new System.Windows.Forms.Button();
            this.btReussis = new System.Windows.Forms.Button();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.gbRechNom = new System.Windows.Forms.GroupBox();
            this.btRech = new System.Windows.Forms.Button();
            this.gbNda = new System.Windows.Forms.GroupBox();
            this.btRechNda = new System.Windows.Forms.Button();
            this.lb_Nda = new System.Windows.Forms.Label();
            this.tbNda = new System.Windows.Forms.TextBox();
            this.lbMoyenne = new System.Windows.Forms.Label();
            this.lbReussis = new System.Windows.Forms.Label();
            this.lbRechNom = new System.Windows.Forms.Label();
            this.lbRechNda = new System.Windows.Forms.Label();
            this.gbRechNom.SuspendLayout();
            this.gbNda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMoy
            // 
            this.btMoy.Location = new System.Drawing.Point(57, 55);
            this.btMoy.Name = "btMoy";
            this.btMoy.Size = new System.Drawing.Size(89, 23);
            this.btMoy.TabIndex = 0;
            this.btMoy.Text = "Moyenne";
            this.btMoy.UseVisualStyleBackColor = true;
            this.btMoy.Click += new System.EventHandler(this.btMoy_Click);
            // 
            // btReussis
            // 
            this.btReussis.Location = new System.Drawing.Point(57, 111);
            this.btReussis.Name = "btReussis";
            this.btReussis.Size = new System.Drawing.Size(89, 23);
            this.btReussis.TabIndex = 1;
            this.btReussis.Text = "Réuissis";
            this.btReussis.UseVisualStyleBackColor = true;
            this.btReussis.Click += new System.EventHandler(this.btReussis_Click);
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Location = new System.Drawing.Point(6, 22);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(41, 17);
            this.lb_Nom.TabIndex = 0;
            this.lb_Nom.Text = "Nom:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(6, 42);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(149, 22);
            this.tbNom.TabIndex = 1;
            // 
            // gbRechNom
            // 
            this.gbRechNom.Controls.Add(this.btRech);
            this.gbRechNom.Controls.Add(this.lb_Nom);
            this.gbRechNom.Controls.Add(this.tbNom);
            this.gbRechNom.Location = new System.Drawing.Point(57, 167);
            this.gbRechNom.Name = "gbRechNom";
            this.gbRechNom.Size = new System.Drawing.Size(200, 100);
            this.gbRechNom.TabIndex = 3;
            this.gbRechNom.TabStop = false;
            this.gbRechNom.Text = "Recherche par nom";
            // 
            // btRech
            // 
            this.btRech.Location = new System.Drawing.Point(71, 71);
            this.btRech.Name = "btRech";
            this.btRech.Size = new System.Drawing.Size(106, 23);
            this.btRech.TabIndex = 2;
            this.btRech.Text = "Recherche";
            this.btRech.UseVisualStyleBackColor = true;
            this.btRech.Click += new System.EventHandler(this.btRech_Click);
            // 
            // gbNda
            // 
            this.gbNda.Controls.Add(this.btRechNda);
            this.gbNda.Controls.Add(this.lb_Nda);
            this.gbNda.Controls.Add(this.tbNda);
            this.gbNda.Location = new System.Drawing.Point(57, 292);
            this.gbNda.Name = "gbNda";
            this.gbNda.Size = new System.Drawing.Size(200, 113);
            this.gbNda.TabIndex = 4;
            this.gbNda.TabStop = false;
            this.gbNda.Text = "Recherche par NDA";
            // 
            // btRechNda
            // 
            this.btRechNda.Location = new System.Drawing.Point(80, 63);
            this.btRechNda.Name = "btRechNda";
            this.btRechNda.Size = new System.Drawing.Size(106, 23);
            this.btRechNda.TabIndex = 5;
            this.btRechNda.Text = "Recherche";
            this.btRechNda.UseVisualStyleBackColor = true;
            this.btRechNda.Click += new System.EventHandler(this.btRechNda_Click);
            // 
            // lb_Nda
            // 
            this.lb_Nda.AutoSize = true;
            this.lb_Nda.Location = new System.Drawing.Point(15, 14);
            this.lb_Nda.Name = "lb_Nda";
            this.lb_Nda.Size = new System.Drawing.Size(41, 17);
            this.lb_Nda.TabIndex = 3;
            this.lb_Nda.Text = "NDA:";
            // 
            // tbNda
            // 
            this.tbNda.Location = new System.Drawing.Point(15, 34);
            this.tbNda.Name = "tbNda";
            this.tbNda.Size = new System.Drawing.Size(149, 22);
            this.tbNda.TabIndex = 4;
            // 
            // lbMoyenne
            // 
            this.lbMoyenne.AutoSize = true;
            this.lbMoyenne.Location = new System.Drawing.Point(210, 60);
            this.lbMoyenne.Name = "lbMoyenne";
            this.lbMoyenne.Size = new System.Drawing.Size(0, 17);
            this.lbMoyenne.TabIndex = 5;
            // 
            // lbReussis
            // 
            this.lbReussis.AutoSize = true;
            this.lbReussis.Location = new System.Drawing.Point(210, 93);
            this.lbReussis.Name = "lbReussis";
            this.lbReussis.Size = new System.Drawing.Size(0, 17);
            this.lbReussis.TabIndex = 6;
            // 
            // lbRechNom
            // 
            this.lbRechNom.AutoSize = true;
            this.lbRechNom.Location = new System.Drawing.Point(295, 214);
            this.lbRechNom.Name = "lbRechNom";
            this.lbRechNom.Size = new System.Drawing.Size(0, 17);
            this.lbRechNom.TabIndex = 7;
            // 
            // lbRechNda
            // 
            this.lbRechNda.AutoSize = true;
            this.lbRechNda.Location = new System.Drawing.Point(282, 331);
            this.lbRechNda.Name = "lbRechNda";
            this.lbRechNda.Size = new System.Drawing.Size(0, 17);
            this.lbRechNda.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRechNda);
            this.Controls.Add(this.lbRechNom);
            this.Controls.Add(this.lbReussis);
            this.Controls.Add(this.lbMoyenne);
            this.Controls.Add(this.gbNda);
            this.Controls.Add(this.gbRechNom);
            this.Controls.Add(this.btReussis);
            this.Controls.Add(this.btMoy);
            this.Name = "Form1";
            this.Text = "Recherche par nom";
            this.gbRechNom.ResumeLayout(false);
            this.gbRechNom.PerformLayout();
            this.gbNda.ResumeLayout(false);
            this.gbNda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMoy;
        private System.Windows.Forms.Button btReussis;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.GroupBox gbRechNom;
        private System.Windows.Forms.Button btRech;
        private System.Windows.Forms.GroupBox gbNda;
        private System.Windows.Forms.Button btRechNda;
        private System.Windows.Forms.Label lb_Nda;
        private System.Windows.Forms.TextBox tbNda;
        private System.Windows.Forms.Label lbMoyenne;
        private System.Windows.Forms.Label lbReussis;
        private System.Windows.Forms.Label lbRechNom;
        private System.Windows.Forms.Label lbRechNda;
    }
}

