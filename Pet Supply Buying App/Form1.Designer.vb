<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Titlelabel = New Label()
        Sloganlabel = New Label()
        AddToCartButton = New Button()
        ClearButton = New Button()
        ChihuahuaRadioButton1 = New RadioButton()
        YorkieRadioButton2 = New RadioButton()
        ShihTzuRadioButton3 = New RadioButton()
        BreedSelectionGroupBox1 = New GroupBox()
        QuantityTextBox1 = New TextBox()
        QuantityLabel1 = New Label()
        FrenchBulldogPriceLabel1 = New Label()
        ShihTzuPriceLabel1 = New Label()
        CaneCorsoPriceLabel1 = New Label()
        YorkiePriceLabel1 = New Label()
        ChiPriceLabel1 = New Label()
        RadioButton1 = New RadioButton()
        CaneCorsoRadioButton1 = New RadioButton()
        RemoveButton1 = New Button()
        Label1 = New Label()
        DisplayTotalPriceLabel2 = New Label()
        BreedSelectionGroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Titlelabel
        ' 
        Titlelabel.AutoSize = True
        Titlelabel.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Titlelabel.Location = New Point(348, 9)
        Titlelabel.Name = "Titlelabel"
        Titlelabel.Size = New Size(566, 37)
        Titlelabel.TabIndex = 0
        Titlelabel.Text = "Puppies Babbies N Supplies One Stop Shop"
        ' 
        ' Sloganlabel
        ' 
        Sloganlabel.AutoSize = True
        Sloganlabel.Font = New Font("Segoe UI", 12F)
        Sloganlabel.Location = New Point(396, 55)
        Sloganlabel.Name = "Sloganlabel"
        Sloganlabel.Size = New Size(440, 21)
        Sloganlabel.TabIndex = 1
        Sloganlabel.Text = "Purchase Your Furby Baby and Supplies At The Same Time!😊"
        ' 
        ' AddToCartButton
        ' 
        AddToCartButton.Location = New Point(36, 658)
        AddToCartButton.Name = "AddToCartButton"
        AddToCartButton.Size = New Size(92, 23)
        AddToCartButton.TabIndex = 2
        AddToCartButton.Text = "Add To Cart"
        AddToCartButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(1005, 658)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(75, 23)
        ClearButton.TabIndex = 3
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ChihuahuaRadioButton1
        ' 
        ChihuahuaRadioButton1.AutoSize = True
        ChihuahuaRadioButton1.Location = New Point(6, 22)
        ChihuahuaRadioButton1.Name = "ChihuahuaRadioButton1"
        ChihuahuaRadioButton1.Size = New Size(83, 19)
        ChihuahuaRadioButton1.TabIndex = 4
        ChihuahuaRadioButton1.TabStop = True
        ChihuahuaRadioButton1.Text = "Chihuahua"
        ChihuahuaRadioButton1.UseVisualStyleBackColor = True
        ' 
        ' YorkieRadioButton2
        ' 
        YorkieRadioButton2.AutoSize = True
        YorkieRadioButton2.Location = New Point(6, 47)
        YorkieRadioButton2.Name = "YorkieRadioButton2"
        YorkieRadioButton2.Size = New Size(57, 19)
        YorkieRadioButton2.TabIndex = 5
        YorkieRadioButton2.TabStop = True
        YorkieRadioButton2.Text = "Yorkie"
        YorkieRadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ShihTzuRadioButton3
        ' 
        ShihTzuRadioButton3.AutoSize = True
        ShihTzuRadioButton3.Location = New Point(6, 72)
        ShihTzuRadioButton3.Name = "ShihTzuRadioButton3"
        ShihTzuRadioButton3.Size = New Size(68, 19)
        ShihTzuRadioButton3.TabIndex = 6
        ShihTzuRadioButton3.TabStop = True
        ShihTzuRadioButton3.Text = "Shih Tzu"
        ShihTzuRadioButton3.UseVisualStyleBackColor = True
        ' 
        ' BreedSelectionGroupBox1
        ' 
        BreedSelectionGroupBox1.Controls.Add(DisplayTotalPriceLabel2)
        BreedSelectionGroupBox1.Controls.Add(Label1)
        BreedSelectionGroupBox1.Controls.Add(QuantityTextBox1)
        BreedSelectionGroupBox1.Controls.Add(QuantityLabel1)
        BreedSelectionGroupBox1.Controls.Add(FrenchBulldogPriceLabel1)
        BreedSelectionGroupBox1.Controls.Add(ShihTzuPriceLabel1)
        BreedSelectionGroupBox1.Controls.Add(CaneCorsoPriceLabel1)
        BreedSelectionGroupBox1.Controls.Add(YorkiePriceLabel1)
        BreedSelectionGroupBox1.Controls.Add(ChiPriceLabel1)
        BreedSelectionGroupBox1.Controls.Add(RadioButton1)
        BreedSelectionGroupBox1.Controls.Add(CaneCorsoRadioButton1)
        BreedSelectionGroupBox1.Controls.Add(ChihuahuaRadioButton1)
        BreedSelectionGroupBox1.Controls.Add(ShihTzuRadioButton3)
        BreedSelectionGroupBox1.Controls.Add(YorkieRadioButton2)
        BreedSelectionGroupBox1.Location = New Point(12, 185)
        BreedSelectionGroupBox1.Name = "BreedSelectionGroupBox1"
        BreedSelectionGroupBox1.Size = New Size(250, 318)
        BreedSelectionGroupBox1.TabIndex = 7
        BreedSelectionGroupBox1.TabStop = False
        BreedSelectionGroupBox1.Text = "Breed Selection"
        ' 
        ' QuantityTextBox1
        ' 
        QuantityTextBox1.Location = New Point(72, 163)
        QuantityTextBox1.Name = "QuantityTextBox1"
        QuantityTextBox1.Size = New Size(66, 23)
        QuantityTextBox1.TabIndex = 15
        ' 
        ' QuantityLabel1
        ' 
        QuantityLabel1.AutoSize = True
        QuantityLabel1.Location = New Point(7, 166)
        QuantityLabel1.Name = "QuantityLabel1"
        QuantityLabel1.Size = New Size(59, 15)
        QuantityLabel1.TabIndex = 14
        QuantityLabel1.Text = "Quantity: "
        ' 
        ' FrenchBulldogPriceLabel1
        ' 
        FrenchBulldogPriceLabel1.AutoSize = True
        FrenchBulldogPriceLabel1.Location = New Point(136, 126)
        FrenchBulldogPriceLabel1.Name = "FrenchBulldogPriceLabel1"
        FrenchBulldogPriceLabel1.Size = New Size(83, 15)
        FrenchBulldogPriceLabel1.TabIndex = 13
        FrenchBulldogPriceLabel1.Text = "$6,000.00 each"
        ' 
        ' ShihTzuPriceLabel1
        ' 
        ShihTzuPriceLabel1.AutoSize = True
        ShihTzuPriceLabel1.Location = New Point(136, 76)
        ShihTzuPriceLabel1.Name = "ShihTzuPriceLabel1"
        ShihTzuPriceLabel1.Size = New Size(83, 15)
        ShihTzuPriceLabel1.TabIndex = 12
        ShihTzuPriceLabel1.Text = "$1,500.00 each"
        ' 
        ' CaneCorsoPriceLabel1
        ' 
        CaneCorsoPriceLabel1.AutoSize = True
        CaneCorsoPriceLabel1.Location = New Point(135, 101)
        CaneCorsoPriceLabel1.Name = "CaneCorsoPriceLabel1"
        CaneCorsoPriceLabel1.Size = New Size(83, 15)
        CaneCorsoPriceLabel1.TabIndex = 11
        CaneCorsoPriceLabel1.Text = "$3,000.00 each"
        ' 
        ' YorkiePriceLabel1
        ' 
        YorkiePriceLabel1.AutoSize = True
        YorkiePriceLabel1.Location = New Point(136, 53)
        YorkiePriceLabel1.Name = "YorkiePriceLabel1"
        YorkiePriceLabel1.Size = New Size(83, 15)
        YorkiePriceLabel1.TabIndex = 10
        YorkiePriceLabel1.Text = "$1,000.00 each"
        ' 
        ' ChiPriceLabel1
        ' 
        ChiPriceLabel1.AutoSize = True
        ChiPriceLabel1.Location = New Point(135, 25)
        ChiPriceLabel1.Name = "ChiPriceLabel1"
        ChiPriceLabel1.Size = New Size(83, 15)
        ChiPriceLabel1.TabIndex = 9
        ChiPriceLabel1.Text = "$2,000.00 each"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 122)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(105, 19)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "French Bulldog"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' CaneCorsoRadioButton1
        ' 
        CaneCorsoRadioButton1.AutoSize = True
        CaneCorsoRadioButton1.Location = New Point(6, 97)
        CaneCorsoRadioButton1.Name = "CaneCorsoRadioButton1"
        CaneCorsoRadioButton1.Size = New Size(86, 19)
        CaneCorsoRadioButton1.TabIndex = 7
        CaneCorsoRadioButton1.TabStop = True
        CaneCorsoRadioButton1.Text = "Cane Corso"
        CaneCorsoRadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RemoveButton1
        ' 
        RemoveButton1.Location = New Point(555, 658)
        RemoveButton1.Name = "RemoveButton1"
        RemoveButton1.Size = New Size(113, 23)
        RemoveButton1.TabIndex = 8
        RemoveButton1.Text = "Remove Item"
        RemoveButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 204)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 16
        Label1.Text = "Total Price:"
        ' 
        ' DisplayTotalPriceLabel2
        ' 
        DisplayTotalPriceLabel2.AutoSize = True
        DisplayTotalPriceLabel2.Location = New Point(79, 204)
        DisplayTotalPriceLabel2.Name = "DisplayTotalPriceLabel2"
        DisplayTotalPriceLabel2.Size = New Size(0, 15)
        DisplayTotalPriceLabel2.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cute_dog_sleeping_ai_generatedBackgroundImage
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1163, 690)
        Controls.Add(RemoveButton1)
        Controls.Add(BreedSelectionGroupBox1)
        Controls.Add(ClearButton)
        Controls.Add(AddToCartButton)
        Controls.Add(Sloganlabel)
        Controls.Add(Titlelabel)
        Name = "Form1"
        Text = "Form1"
        BreedSelectionGroupBox1.ResumeLayout(False)
        BreedSelectionGroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Titlelabel As Label
    Friend WithEvents Sloganlabel As Label
    Friend WithEvents AddToCartButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ChihuahuaRadioButton1 As RadioButton
    Friend WithEvents YorkieRadioButton2 As RadioButton
    Friend WithEvents ShihTzuRadioButton3 As RadioButton
    Friend WithEvents BreedSelectionGroupBox1 As GroupBox
    Friend WithEvents CaneCorsoRadioButton1 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ChiPriceLabel1 As Label
    Friend WithEvents RemoveButton1 As Button
    Friend WithEvents ShihTzuPriceLabel1 As Label
    Friend WithEvents CaneCorsoPriceLabel1 As Label
    Friend WithEvents YorkiePriceLabel1 As Label
    Friend WithEvents FrenchBulldogPriceLabel1 As Label
    Friend WithEvents QuantityTextBox1 As TextBox
    Friend WithEvents QuantityLabel1 As Label
    Friend WithEvents DisplayTotalPriceLabel2 As Label
    Friend WithEvents Label1 As Label

End Class
