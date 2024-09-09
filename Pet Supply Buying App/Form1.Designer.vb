<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class Form1
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
        ClearButton = New Button()
        ChihuahuaRadioButton1 = New RadioButton()
        YorkieRadioButton2 = New RadioButton()
        ShihTzuRadioButton3 = New RadioButton()
        BreedSelectionGroupBox1 = New GroupBox()
        TotalPriceDisplayLabel3 = New Label()
        TotalPriceDisplayLabel1 = New Label()
        RemoveButton1 = New Button()
        PNBDishesLabel2 = New Label()
        PNBDishesRadioButton2 = New RadioButton()
        PNBDewormerLabel3 = New Label()
        AddToCartButton = New Button()
        PNBDewormerRadioButton2 = New RadioButton()
        IncludesshampooandconditionerLabel3 = New Label()
        PNBShampooLabel2 = New Label()
        PNBShampooRadioButton2 = New RadioButton()
        DisplayTotalPriceLabel2 = New Label()
        QuantityTextBox1 = New TextBox()
        QuantityLabel1 = New Label()
        FrenchBulldogPriceLabel1 = New Label()
        ShihTzuPriceLabel1 = New Label()
        CaneCorsoPriceLabel1 = New Label()
        YorkiePriceLabel1 = New Label()
        ChiPriceLabel1 = New Label()
        RadioButton1 = New RadioButton()
        CaneCorsoRadioButton1 = New RadioButton()
        Label2 = New Label()
        lstCart = New ListBox()
        priceLabel1 = New Label()
        BreedSelectionGroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Titlelabel
        ' 
        Titlelabel.AutoSize = True
        Titlelabel.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        Titlelabel.Location = New Point(348, 9)
        Titlelabel.Name = "Titlelabel"
        Titlelabel.Size = New Size(566, 37)
        Titlelabel.TabIndex = 0
        Titlelabel.Text = "Puppies Babbies N Supplies One Stop Shop"
        ' 
        ' Sloganlabel
        ' 
        Sloganlabel.AutoSize = True
        Sloganlabel.Font = New Font("Segoe UI", 12.0F)
        Sloganlabel.Location = New Point(396, 55)
        Sloganlabel.Name = "Sloganlabel"
        Sloganlabel.Size = New Size(440, 21)
        Sloganlabel.TabIndex = 1
        Sloganlabel.Text = "Purchase Your Furby Baby and Supplies At The Same Time!😊"
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(451, 289)
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
        BreedSelectionGroupBox1.Controls.Add(priceLabel1)
        BreedSelectionGroupBox1.Controls.Add(TotalPriceDisplayLabel3)
        BreedSelectionGroupBox1.Controls.Add(TotalPriceDisplayLabel1)
        BreedSelectionGroupBox1.Controls.Add(RemoveButton1)
        BreedSelectionGroupBox1.Controls.Add(ClearButton)
        BreedSelectionGroupBox1.Controls.Add(PNBDishesLabel2)
        BreedSelectionGroupBox1.Controls.Add(PNBDishesRadioButton2)
        BreedSelectionGroupBox1.Controls.Add(PNBDewormerLabel3)
        BreedSelectionGroupBox1.Controls.Add(AddToCartButton)
        BreedSelectionGroupBox1.Controls.Add(PNBDewormerRadioButton2)
        BreedSelectionGroupBox1.Controls.Add(IncludesshampooandconditionerLabel3)
        BreedSelectionGroupBox1.Controls.Add(PNBShampooLabel2)
        BreedSelectionGroupBox1.Controls.Add(PNBShampooRadioButton2)
        BreedSelectionGroupBox1.Controls.Add(DisplayTotalPriceLabel2)
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
        BreedSelectionGroupBox1.Size = New Size(556, 318)
        BreedSelectionGroupBox1.TabIndex = 7
        BreedSelectionGroupBox1.TabStop = False
        BreedSelectionGroupBox1.Text = "Breed Selection N Supplies"
        ' 
        ' TotalPriceDisplayLabel3
        ' 
        TotalPriceDisplayLabel3.AutoSize = True
        TotalPriceDisplayLabel3.Location = New Point(91, 252)
        TotalPriceDisplayLabel3.Name = "TotalPriceDisplayLabel3"
        TotalPriceDisplayLabel3.Size = New Size(36, 15)
        TotalPriceDisplayLabel3.TabIndex = 26
        TotalPriceDisplayLabel3.Text = "Price "
        ' 
        ' TotalPriceDisplayLabel1
        ' 
        TotalPriceDisplayLabel1.AutoSize = True
        TotalPriceDisplayLabel1.Location = New Point(15, 252)
        TotalPriceDisplayLabel1.Name = "TotalPriceDisplayLabel1"
        TotalPriceDisplayLabel1.Size = New Size(64, 15)
        TotalPriceDisplayLabel1.TabIndex = 18
        TotalPriceDisplayLabel1.Text = "Total Price:"
        ' 
        ' RemoveButton1
        ' 
        RemoveButton1.Location = New Point(213, 289)
        RemoveButton1.Name = "RemoveButton1"
        RemoveButton1.Size = New Size(113, 23)
        RemoveButton1.TabIndex = 8
        RemoveButton1.Text = "Remove Item"
        RemoveButton1.UseVisualStyleBackColor = True
        ' 
        ' PNBDishesLabel2
        ' 
        PNBDishesLabel2.AutoSize = True
        PNBDishesLabel2.Location = New Point(412, 101)
        PNBDishesLabel2.Name = "PNBDishesLabel2"
        PNBDishesLabel2.Size = New Size(68, 15)
        PNBDishesLabel2.TabIndex = 24
        PNBDishesLabel2.Text = "$40.99 each"
        ' 
        ' PNBDishesRadioButton2
        ' 
        PNBDishesRadioButton2.AutoSize = True
        PNBDishesRadioButton2.Location = New Point(285, 101)
        PNBDishesRadioButton2.Name = "PNBDishesRadioButton2"
        PNBDishesRadioButton2.Size = New Size(85, 19)
        PNBDishesRadioButton2.TabIndex = 23
        PNBDishesRadioButton2.TabStop = True
        PNBDishesRadioButton2.Text = "PNB Dishes"
        PNBDishesRadioButton2.UseVisualStyleBackColor = True
        ' 
        ' PNBDewormerLabel3
        ' 
        PNBDewormerLabel3.AutoSize = True
        PNBDewormerLabel3.Location = New Point(412, 74)
        PNBDewormerLabel3.Name = "PNBDewormerLabel3"
        PNBDewormerLabel3.Size = New Size(68, 15)
        PNBDewormerLabel3.TabIndex = 22
        PNBDewormerLabel3.Text = "$20.99 each"
        ' 
        ' AddToCartButton
        ' 
        AddToCartButton.Location = New Point(6, 289)
        AddToCartButton.Name = "AddToCartButton"
        AddToCartButton.Size = New Size(92, 23)
        AddToCartButton.TabIndex = 2
        AddToCartButton.Text = "Add To Cart"
        AddToCartButton.UseVisualStyleBackColor = True
        ' 
        ' PNBDewormerRadioButton2
        ' 
        PNBDewormerRadioButton2.AutoSize = True
        PNBDewormerRadioButton2.Location = New Point(285, 72)
        PNBDewormerRadioButton2.Name = "PNBDewormerRadioButton2"
        PNBDewormerRadioButton2.Size = New Size(106, 19)
        PNBDewormerRadioButton2.TabIndex = 21
        PNBDewormerRadioButton2.TabStop = True
        PNBDewormerRadioButton2.Text = "PNB Dewormer"
        PNBDewormerRadioButton2.UseVisualStyleBackColor = True
        ' 
        ' IncludesshampooandconditionerLabel3
        ' 
        IncludesshampooandconditionerLabel3.AutoSize = True
        IncludesshampooandconditionerLabel3.Location = New Point(285, 42)
        IncludesshampooandconditionerLabel3.Name = "IncludesshampooandconditionerLabel3"
        IncludesshampooandconditionerLabel3.Size = New Size(241, 15)
        IncludesshampooandconditionerLabel3.TabIndex = 20
        IncludesshampooandconditionerLabel3.Text = "Includes  Includes shampoo and conditioner"
        ' 
        ' PNBShampooLabel2
        ' 
        PNBShampooLabel2.AutoSize = True
        PNBShampooLabel2.Location = New Point(412, 27)
        PNBShampooLabel2.Name = "PNBShampooLabel2"
        PNBShampooLabel2.Size = New Size(68, 15)
        PNBShampooLabel2.TabIndex = 19
        PNBShampooLabel2.Text = "$49.99 each"
        ' 
        ' PNBShampooRadioButton2
        ' 
        PNBShampooRadioButton2.AutoSize = True
        PNBShampooRadioButton2.Location = New Point(285, 23)
        PNBShampooRadioButton2.Name = "PNBShampooRadioButton2"
        PNBShampooRadioButton2.Size = New Size(121, 19)
        PNBShampooRadioButton2.TabIndex = 18
        PNBShampooRadioButton2.TabStop = True
        PNBShampooRadioButton2.Text = "PNB Shampoo Set"
        PNBShampooRadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DisplayTotalPriceLabel2
        ' 
        DisplayTotalPriceLabel2.AutoSize = True
        DisplayTotalPriceLabel2.Location = New Point(79, 204)
        DisplayTotalPriceLabel2.Name = "DisplayTotalPriceLabel2"
        DisplayTotalPriceLabel2.Size = New Size(0, 15)
        DisplayTotalPriceLabel2.TabIndex = 17
        ' 
        ' QuantityTextBox1
        ' 
        QuantityTextBox1.Location = New Point(227, 158)
        QuantityTextBox1.Name = "QuantityTextBox1"
        QuantityTextBox1.Size = New Size(66, 23)
        QuantityTextBox1.TabIndex = 15
        ' 
        ' QuantityLabel1
        ' 
        QuantityLabel1.AutoSize = True
        QuantityLabel1.Location = New Point(159, 161)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(126, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 25
        Label2.Text = "Label2"
        ' 
        ' lstCart
        ' 
        lstCart.FormattingEnabled = True
        lstCart.ItemHeight = 15
        lstCart.Location = New Point(669, 79)
        lstCart.Name = "lstCart"
        lstCart.Size = New Size(294, 184)
        lstCart.TabIndex = 8
        ' 
        ' priceLabel1
        ' 
        priceLabel1.AutoSize = True
        priceLabel1.Location = New Point(155, 189)
        priceLabel1.Name = "priceLabel1"
        priceLabel1.Size = New Size(41, 15)
        priceLabel1.TabIndex = 27
        priceLabel1.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cute_dog_sleeping_ai_generatedBackgroundImage
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1163, 690)
        Controls.Add(lstCart)
        Controls.Add(BreedSelectionGroupBox1)
        Controls.Add(Label2)
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
    Friend WithEvents PNBShampooRadioButton2 As RadioButton

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles PNBShampooRadioButton2.CheckedChanged

    End Sub

    Friend WithEvents IncludesshampooandconditionerLabel3 As Label
    Friend WithEvents PNBShampooLabel2 As Label
    Friend WithEvents PNBDewormerLabel3 As Label
    Friend WithEvents PNBDewormerRadioButton2 As RadioButton
    Friend WithEvents PNBDishesLabel2 As Label
    Friend WithEvents PNBDishesRadioButton2 As RadioButton

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub

    Friend WithEvents lstCart As ListBox
    Friend WithEvents AddToCartButton As Button

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents TotalPriceDisplayLabel1 As Label
    Friend WithEvents TotalPriceDisplayLabel3 As Label
    Friend WithEvents Label2 As Label

    Private Sub AddToCartButton_Click(sender As Object, e As EventArgs) Handles AddToCartButton.Click

        'Add the item and price to total price and listbox to display cost and items


        TotalPriceDisplayLabel3.Visible = True


        Dim strSelection As String = ""
        Dim itemName As String = ""
        Dim quantity As Integer = CInt(numQuantity.Value)
        Dim price As Decimal = CDec(numPrice.Value)

        'Total Price Calculation
        Dim totalPrice As Decimal = quantity * price

        'Calculate the total price for this item
        Dim completeTotalprice As Decimal = quantity * price

        'Add the item to the cart(listbox)
        lstCart.Items.Add($"{itemName}-{quantity} * {price:C} = {totalPrice:C}")




        'Price total updates
        UpdateTotal()


    End Sub

    Private Sub UpdateTotal()
        Dim Total As Decimal = 0D

        'Add each item in the cart
        For Each item As String In lstCart.Items
            'extract
            Dim parts() As String = item.Split("="c)
            Dim itemTotal As Decimal = CDec(parts(1).Trim().Substring(1))
            Total += itemTotal
        Next
        TotalPriceDisplayLabel3.Text = $"Total: {Total:C}"
    End Sub

    Friend WithEvents priceLabel1 As Label
End Class
