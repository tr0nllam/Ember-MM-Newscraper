﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEditTVEpisode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgEditTVEpisode))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Local Subtitles", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("1")
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTopDetails = New System.Windows.Forms.Label()
        Me.lblTopTitle = New System.Windows.Forms.Label()
        Me.pbTopLogo = New System.Windows.Forms.PictureBox()
        Me.tcEdit = New System.Windows.Forms.TabControl()
        Me.tpDetails = New System.Windows.Forms.TabPage()
        Me.txtVideoSource = New System.Windows.Forms.TextBox()
        Me.lblVideoSource = New System.Windows.Forms.Label()
        Me.txtVotes = New System.Windows.Forms.TextBox()
        Me.lblVotes = New System.Windows.Forms.Label()
        Me.lblRuntime = New System.Windows.Forms.Label()
        Me.txtRuntime = New System.Windows.Forms.TextBox()
        Me.pbStar10 = New System.Windows.Forms.PictureBox()
        Me.pbStar9 = New System.Windows.Forms.PictureBox()
        Me.pbStar8 = New System.Windows.Forms.PictureBox()
        Me.pbStar7 = New System.Windows.Forms.PictureBox()
        Me.pbStar6 = New System.Windows.Forms.PictureBox()
        Me.btnActorDown = New System.Windows.Forms.Button()
        Me.btnActorUp = New System.Windows.Forms.Button()
        Me.txtAired = New System.Windows.Forms.TextBox()
        Me.txtEpisode = New System.Windows.Forms.TextBox()
        Me.lblEpisode = New System.Windows.Forms.Label()
        Me.txtSeason = New System.Windows.Forms.TextBox()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.btnEditActor = New System.Windows.Forms.Button()
        Me.btnAddActor = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblActors = New System.Windows.Forms.Label()
        Me.lvActors = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRole = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colThumb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.lblPlot = New System.Windows.Forms.Label()
        Me.txtPlot = New System.Windows.Forms.TextBox()
        Me.pbStar5 = New System.Windows.Forms.PictureBox()
        Me.pbStar4 = New System.Windows.Forms.PictureBox()
        Me.pbStar3 = New System.Windows.Forms.PictureBox()
        Me.pbStar2 = New System.Windows.Forms.PictureBox()
        Me.pbStar1 = New System.Windows.Forms.PictureBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblAired = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.tpPoster = New System.Windows.Forms.TabPage()
        Me.btnSetPosterDL = New System.Windows.Forms.Button()
        Me.btnRemovePoster = New System.Windows.Forms.Button()
        Me.lblPosterSize = New System.Windows.Forms.Label()
        Me.btnSetPosterScrape = New System.Windows.Forms.Button()
        Me.btnSetPoster = New System.Windows.Forms.Button()
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        Me.tpFanart = New System.Windows.Forms.TabPage()
        Me.lblFanartSize = New System.Windows.Forms.Label()
        Me.btnSetFanartDL = New System.Windows.Forms.Button()
        Me.btnRemoveFanart = New System.Windows.Forms.Button()
        Me.btnSetFanartScrape = New System.Windows.Forms.Button()
        Me.btnSetFanart = New System.Windows.Forms.Button()
        Me.pbFanart = New System.Windows.Forms.PictureBox()
        Me.tpFrameExtraction = New System.Windows.Forms.TabPage()
        Me.pnlFrameExtrator = New System.Windows.Forms.Panel()
        Me.tpSubtitles = New System.Windows.Forms.TabPage()
        Me.lblSubtitlesPreview = New System.Windows.Forms.Label()
        Me.txtSubtitlesPreview = New System.Windows.Forms.TextBox()
        Me.lvSubtitles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemoveEpisodeSubtitle = New System.Windows.Forms.Button()
        Me.btnSetMovieSubtitleDL = New System.Windows.Forms.Button()
        Me.btnSetMovieSubtitleScrape = New System.Windows.Forms.Button()
        Me.btnSetMovieSubtitleLocal = New System.Windows.Forms.Button()
        Me.tpMetaData = New System.Windows.Forms.TabPage()
        Me.pnlFileInfo = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.chkWatched = New System.Windows.Forms.CheckBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsFilename = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtLastPlayed = New System.Windows.Forms.TextBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.pbTopLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEdit.SuspendLayout()
        Me.tpDetails.SuspendLayout()
        CType(Me.pbStar10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPoster.SuspendLayout()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFanart.SuspendLayout()
        CType(Me.pbFanart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFrameExtraction.SuspendLayout()
        Me.tpSubtitles.SuspendLayout()
        Me.tpMetaData.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.lblTopDetails)
        Me.pnlTop.Controls.Add(Me.lblTopTitle)
        Me.pnlTop.Controls.Add(Me.pbTopLogo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(854, 64)
        Me.pnlTop.TabIndex = 2
        '
        'lblTopDetails
        '
        Me.lblTopDetails.AutoSize = True
        Me.lblTopDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblTopDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopDetails.ForeColor = System.Drawing.Color.White
        Me.lblTopDetails.Location = New System.Drawing.Point(61, 38)
        Me.lblTopDetails.Name = "lblTopDetails"
        Me.lblTopDetails.Size = New System.Drawing.Size(214, 13)
        Me.lblTopDetails.TabIndex = 1
        Me.lblTopDetails.Text = "Edit the details for the selected episode."
        '
        'lblTopTitle
        '
        Me.lblTopTitle.AutoSize = True
        Me.lblTopTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTopTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopTitle.ForeColor = System.Drawing.Color.White
        Me.lblTopTitle.Location = New System.Drawing.Point(58, 3)
        Me.lblTopTitle.Name = "lblTopTitle"
        Me.lblTopTitle.Size = New System.Drawing.Size(155, 32)
        Me.lblTopTitle.TabIndex = 0
        Me.lblTopTitle.Text = "Edit Episode"
        '
        'pbTopLogo
        '
        Me.pbTopLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbTopLogo.ErrorImage = Nothing
        Me.pbTopLogo.Image = CType(resources.GetObject("pbTopLogo.Image"), System.Drawing.Image)
        Me.pbTopLogo.InitialImage = Nothing
        Me.pbTopLogo.Location = New System.Drawing.Point(7, 8)
        Me.pbTopLogo.Name = "pbTopLogo"
        Me.pbTopLogo.Size = New System.Drawing.Size(48, 48)
        Me.pbTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbTopLogo.TabIndex = 0
        Me.pbTopLogo.TabStop = False
        '
        'tcEdit
        '
        Me.tcEdit.Controls.Add(Me.tpDetails)
        Me.tcEdit.Controls.Add(Me.tpPoster)
        Me.tcEdit.Controls.Add(Me.tpFanart)
        Me.tcEdit.Controls.Add(Me.tpFrameExtraction)
        Me.tcEdit.Controls.Add(Me.tpSubtitles)
        Me.tcEdit.Controls.Add(Me.tpMetaData)
        Me.tcEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcEdit.Location = New System.Drawing.Point(4, 70)
        Me.tcEdit.Name = "tcEdit"
        Me.tcEdit.SelectedIndex = 0
        Me.tcEdit.Size = New System.Drawing.Size(844, 478)
        Me.tcEdit.TabIndex = 3
        '
        'tpDetails
        '
        Me.tpDetails.Controls.Add(Me.txtVideoSource)
        Me.tpDetails.Controls.Add(Me.lblVideoSource)
        Me.tpDetails.Controls.Add(Me.txtVotes)
        Me.tpDetails.Controls.Add(Me.lblVotes)
        Me.tpDetails.Controls.Add(Me.lblRuntime)
        Me.tpDetails.Controls.Add(Me.txtRuntime)
        Me.tpDetails.Controls.Add(Me.pbStar10)
        Me.tpDetails.Controls.Add(Me.pbStar9)
        Me.tpDetails.Controls.Add(Me.pbStar8)
        Me.tpDetails.Controls.Add(Me.pbStar7)
        Me.tpDetails.Controls.Add(Me.pbStar6)
        Me.tpDetails.Controls.Add(Me.btnActorDown)
        Me.tpDetails.Controls.Add(Me.btnActorUp)
        Me.tpDetails.Controls.Add(Me.txtAired)
        Me.tpDetails.Controls.Add(Me.txtEpisode)
        Me.tpDetails.Controls.Add(Me.lblEpisode)
        Me.tpDetails.Controls.Add(Me.txtSeason)
        Me.tpDetails.Controls.Add(Me.lblSeason)
        Me.tpDetails.Controls.Add(Me.lblCredits)
        Me.tpDetails.Controls.Add(Me.txtCredits)
        Me.tpDetails.Controls.Add(Me.btnEditActor)
        Me.tpDetails.Controls.Add(Me.btnAddActor)
        Me.tpDetails.Controls.Add(Me.btnManual)
        Me.tpDetails.Controls.Add(Me.btnRemove)
        Me.tpDetails.Controls.Add(Me.lblActors)
        Me.tpDetails.Controls.Add(Me.lvActors)
        Me.tpDetails.Controls.Add(Me.lblDirector)
        Me.tpDetails.Controls.Add(Me.txtDirector)
        Me.tpDetails.Controls.Add(Me.lblPlot)
        Me.tpDetails.Controls.Add(Me.txtPlot)
        Me.tpDetails.Controls.Add(Me.pbStar5)
        Me.tpDetails.Controls.Add(Me.pbStar4)
        Me.tpDetails.Controls.Add(Me.pbStar3)
        Me.tpDetails.Controls.Add(Me.pbStar2)
        Me.tpDetails.Controls.Add(Me.pbStar1)
        Me.tpDetails.Controls.Add(Me.lblRating)
        Me.tpDetails.Controls.Add(Me.lblAired)
        Me.tpDetails.Controls.Add(Me.lblTitle)
        Me.tpDetails.Controls.Add(Me.txtTitle)
        Me.tpDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpDetails.Name = "tpDetails"
        Me.tpDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetails.Size = New System.Drawing.Size(836, 452)
        Me.tpDetails.TabIndex = 0
        Me.tpDetails.Text = "Details"
        Me.tpDetails.UseVisualStyleBackColor = True
        '
        'txtVideoSource
        '
        Me.txtVideoSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtVideoSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVideoSource.Location = New System.Drawing.Point(645, 395)
        Me.txtVideoSource.Name = "txtVideoSource"
        Me.txtVideoSource.Size = New System.Drawing.Size(183, 22)
        Me.txtVideoSource.TabIndex = 88
        '
        'lblVideoSource
        '
        Me.lblVideoSource.AutoSize = True
        Me.lblVideoSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVideoSource.Location = New System.Drawing.Point(643, 380)
        Me.lblVideoSource.Name = "lblVideoSource"
        Me.lblVideoSource.Size = New System.Drawing.Size(78, 13)
        Me.lblVideoSource.TabIndex = 87
        Me.lblVideoSource.Text = "Video Source:"
        '
        'txtVotes
        '
        Me.txtVotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtVotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVotes.Location = New System.Drawing.Point(738, 155)
        Me.txtVotes.Name = "txtVotes"
        Me.txtVotes.Size = New System.Drawing.Size(66, 22)
        Me.txtVotes.TabIndex = 86
        '
        'lblVotes
        '
        Me.lblVotes.AutoSize = True
        Me.lblVotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVotes.Location = New System.Drawing.Point(735, 140)
        Me.lblVotes.Name = "lblVotes"
        Me.lblVotes.Size = New System.Drawing.Size(38, 13)
        Me.lblVotes.TabIndex = 85
        Me.lblVotes.Text = "Votes:"
        '
        'lblRuntime
        '
        Me.lblRuntime.AutoSize = True
        Me.lblRuntime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRuntime.Location = New System.Drawing.Point(645, 139)
        Me.lblRuntime.Name = "lblRuntime"
        Me.lblRuntime.Size = New System.Drawing.Size(54, 13)
        Me.lblRuntime.TabIndex = 83
        Me.lblRuntime.Text = "Runtime:"
        '
        'txtRuntime
        '
        Me.txtRuntime.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuntime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtRuntime.Location = New System.Drawing.Point(645, 155)
        Me.txtRuntime.Name = "txtRuntime"
        Me.txtRuntime.Size = New System.Drawing.Size(66, 22)
        Me.txtRuntime.TabIndex = 84
        '
        'pbStar10
        '
        Me.pbStar10.Location = New System.Drawing.Point(224, 110)
        Me.pbStar10.Name = "pbStar10"
        Me.pbStar10.Size = New System.Drawing.Size(24, 24)
        Me.pbStar10.TabIndex = 82
        Me.pbStar10.TabStop = False
        '
        'pbStar9
        '
        Me.pbStar9.Location = New System.Drawing.Point(200, 110)
        Me.pbStar9.Name = "pbStar9"
        Me.pbStar9.Size = New System.Drawing.Size(24, 24)
        Me.pbStar9.TabIndex = 81
        Me.pbStar9.TabStop = False
        '
        'pbStar8
        '
        Me.pbStar8.Location = New System.Drawing.Point(176, 110)
        Me.pbStar8.Name = "pbStar8"
        Me.pbStar8.Size = New System.Drawing.Size(24, 24)
        Me.pbStar8.TabIndex = 80
        Me.pbStar8.TabStop = False
        '
        'pbStar7
        '
        Me.pbStar7.Location = New System.Drawing.Point(152, 110)
        Me.pbStar7.Name = "pbStar7"
        Me.pbStar7.Size = New System.Drawing.Size(24, 24)
        Me.pbStar7.TabIndex = 79
        Me.pbStar7.TabStop = False
        '
        'pbStar6
        '
        Me.pbStar6.Location = New System.Drawing.Point(128, 110)
        Me.pbStar6.Name = "pbStar6"
        Me.pbStar6.Size = New System.Drawing.Size(24, 24)
        Me.pbStar6.TabIndex = 78
        Me.pbStar6.TabStop = False
        '
        'btnActorDown
        '
        Me.btnActorDown.Image = CType(resources.GetObject("btnActorDown.Image"), System.Drawing.Image)
        Me.btnActorDown.Location = New System.Drawing.Point(328, 423)
        Me.btnActorDown.Name = "btnActorDown"
        Me.btnActorDown.Size = New System.Drawing.Size(23, 23)
        Me.btnActorDown.TabIndex = 20
        Me.btnActorDown.UseVisualStyleBackColor = True
        '
        'btnActorUp
        '
        Me.btnActorUp.Image = CType(resources.GetObject("btnActorUp.Image"), System.Drawing.Image)
        Me.btnActorUp.Location = New System.Drawing.Point(304, 423)
        Me.btnActorUp.Name = "btnActorUp"
        Me.btnActorUp.Size = New System.Drawing.Size(23, 23)
        Me.btnActorUp.TabIndex = 19
        Me.btnActorUp.UseVisualStyleBackColor = True
        '
        'txtAired
        '
        Me.txtAired.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAired.Location = New System.Drawing.Point(111, 67)
        Me.txtAired.Name = "txtAired"
        Me.txtAired.Size = New System.Drawing.Size(137, 22)
        Me.txtAired.TabIndex = 9
        '
        'txtEpisode
        '
        Me.txtEpisode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpisode.Location = New System.Drawing.Point(59, 67)
        Me.txtEpisode.Name = "txtEpisode"
        Me.txtEpisode.Size = New System.Drawing.Size(46, 22)
        Me.txtEpisode.TabIndex = 7
        '
        'lblEpisode
        '
        Me.lblEpisode.AutoSize = True
        Me.lblEpisode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblEpisode.Location = New System.Drawing.Point(59, 51)
        Me.lblEpisode.Name = "lblEpisode"
        Me.lblEpisode.Size = New System.Drawing.Size(51, 13)
        Me.lblEpisode.TabIndex = 6
        Me.lblEpisode.Text = "Episode:"
        '
        'txtSeason
        '
        Me.txtSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeason.Location = New System.Drawing.Point(7, 67)
        Me.txtSeason.Name = "txtSeason"
        Me.txtSeason.Size = New System.Drawing.Size(46, 22)
        Me.txtSeason.TabIndex = 5
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSeason.Location = New System.Drawing.Point(7, 51)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(47, 13)
        Me.lblSeason.TabIndex = 4
        Me.lblSeason.Text = "Season:"
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(267, 139)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(46, 13)
        Me.lblCredits.TabIndex = 13
        Me.lblCredits.Text = "Credits:"
        '
        'txtCredits
        '
        Me.txtCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredits.Location = New System.Drawing.Point(270, 155)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(355, 22)
        Me.txtCredits.TabIndex = 14
        '
        'btnEditActor
        '
        Me.btnEditActor.Image = CType(resources.GetObject("btnEditActor.Image"), System.Drawing.Image)
        Me.btnEditActor.Location = New System.Drawing.Point(35, 423)
        Me.btnEditActor.Name = "btnEditActor"
        Me.btnEditActor.Size = New System.Drawing.Size(23, 23)
        Me.btnEditActor.TabIndex = 18
        Me.btnEditActor.UseVisualStyleBackColor = True
        '
        'btnAddActor
        '
        Me.btnAddActor.Image = CType(resources.GetObject("btnAddActor.Image"), System.Drawing.Image)
        Me.btnAddActor.Location = New System.Drawing.Point(6, 423)
        Me.btnAddActor.Name = "btnAddActor"
        Me.btnAddActor.Size = New System.Drawing.Size(23, 23)
        Me.btnAddActor.TabIndex = 17
        Me.btnAddActor.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.Location = New System.Drawing.Point(738, 423)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(92, 23)
        Me.btnManual.TabIndex = 22
        Me.btnManual.Text = "Manual Edit"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(602, 423)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnRemove.TabIndex = 21
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblActors
        '
        Me.lblActors.AutoSize = True
        Me.lblActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblActors.Location = New System.Drawing.Point(7, 188)
        Me.lblActors.Name = "lblActors"
        Me.lblActors.Size = New System.Drawing.Size(43, 13)
        Me.lblActors.TabIndex = 15
        Me.lblActors.Text = "Actors:"
        '
        'lvActors
        '
        Me.lvActors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colRole, Me.colThumb})
        Me.lvActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvActors.FullRowSelect = True
        Me.lvActors.Location = New System.Drawing.Point(7, 204)
        Me.lvActors.Name = "lvActors"
        Me.lvActors.Size = New System.Drawing.Size(618, 213)
        Me.lvActors.TabIndex = 16
        Me.lvActors.UseCompatibleStateImageBehavior = False
        Me.lvActors.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Width = 0
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 110
        '
        'colRole
        '
        Me.colRole.Text = "Role"
        Me.colRole.Width = 100
        '
        'colThumb
        '
        Me.colThumb.Text = "Thumb"
        Me.colThumb.Width = 387
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(7, 139)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(51, 13)
        Me.lblDirector.TabIndex = 11
        Me.lblDirector.Text = "Director:"
        '
        'txtDirector
        '
        Me.txtDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirector.Location = New System.Drawing.Point(7, 155)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(241, 22)
        Me.txtDirector.TabIndex = 12
        '
        'lblPlot
        '
        Me.lblPlot.AutoSize = True
        Me.lblPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPlot.Location = New System.Drawing.Point(267, 7)
        Me.lblPlot.Name = "lblPlot"
        Me.lblPlot.Size = New System.Drawing.Size(31, 13)
        Me.lblPlot.TabIndex = 2
        Me.lblPlot.Text = "Plot:"
        '
        'txtPlot
        '
        Me.txtPlot.AcceptsReturn = True
        Me.txtPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlot.Location = New System.Drawing.Point(270, 26)
        Me.txtPlot.Multiline = True
        Me.txtPlot.Name = "txtPlot"
        Me.txtPlot.Size = New System.Drawing.Size(558, 108)
        Me.txtPlot.TabIndex = 3
        '
        'pbStar5
        '
        Me.pbStar5.Location = New System.Drawing.Point(104, 110)
        Me.pbStar5.Name = "pbStar5"
        Me.pbStar5.Size = New System.Drawing.Size(24, 24)
        Me.pbStar5.TabIndex = 67
        Me.pbStar5.TabStop = False
        '
        'pbStar4
        '
        Me.pbStar4.Location = New System.Drawing.Point(80, 110)
        Me.pbStar4.Name = "pbStar4"
        Me.pbStar4.Size = New System.Drawing.Size(24, 24)
        Me.pbStar4.TabIndex = 66
        Me.pbStar4.TabStop = False
        '
        'pbStar3
        '
        Me.pbStar3.Location = New System.Drawing.Point(56, 110)
        Me.pbStar3.Name = "pbStar3"
        Me.pbStar3.Size = New System.Drawing.Size(24, 24)
        Me.pbStar3.TabIndex = 65
        Me.pbStar3.TabStop = False
        '
        'pbStar2
        '
        Me.pbStar2.Location = New System.Drawing.Point(32, 110)
        Me.pbStar2.Name = "pbStar2"
        Me.pbStar2.Size = New System.Drawing.Size(24, 24)
        Me.pbStar2.TabIndex = 64
        Me.pbStar2.TabStop = False
        '
        'pbStar1
        '
        Me.pbStar1.Location = New System.Drawing.Point(8, 110)
        Me.pbStar1.Name = "pbStar1"
        Me.pbStar1.Size = New System.Drawing.Size(24, 24)
        Me.pbStar1.TabIndex = 63
        Me.pbStar1.TabStop = False
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRating.Location = New System.Drawing.Point(7, 94)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(44, 13)
        Me.lblRating.TabIndex = 10
        Me.lblRating.Text = "Rating:"
        '
        'lblAired
        '
        Me.lblAired.AutoSize = True
        Me.lblAired.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAired.Location = New System.Drawing.Point(111, 51)
        Me.lblAired.Name = "lblAired"
        Me.lblAired.Size = New System.Drawing.Size(38, 13)
        Me.lblAired.TabIndex = 8
        Me.lblAired.Text = "Aired:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(7, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(32, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(7, 26)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(241, 22)
        Me.txtTitle.TabIndex = 1
        '
        'tpPoster
        '
        Me.tpPoster.Controls.Add(Me.btnSetPosterDL)
        Me.tpPoster.Controls.Add(Me.btnRemovePoster)
        Me.tpPoster.Controls.Add(Me.lblPosterSize)
        Me.tpPoster.Controls.Add(Me.btnSetPosterScrape)
        Me.tpPoster.Controls.Add(Me.btnSetPoster)
        Me.tpPoster.Controls.Add(Me.pbPoster)
        Me.tpPoster.Location = New System.Drawing.Point(4, 22)
        Me.tpPoster.Name = "tpPoster"
        Me.tpPoster.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPoster.Size = New System.Drawing.Size(836, 452)
        Me.tpPoster.TabIndex = 1
        Me.tpPoster.Text = "Poster"
        Me.tpPoster.UseVisualStyleBackColor = True
        '
        'btnSetPosterDL
        '
        Me.btnSetPosterDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPosterDL.Image = CType(resources.GetObject("btnSetPosterDL.Image"), System.Drawing.Image)
        Me.btnSetPosterDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetPosterDL.Location = New System.Drawing.Point(735, 180)
        Me.btnSetPosterDL.Name = "btnSetPosterDL"
        Me.btnSetPosterDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetPosterDL.TabIndex = 3
        Me.btnSetPosterDL.Text = "Change Poster (Download)"
        Me.btnSetPosterDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetPosterDL.UseVisualStyleBackColor = True
        '
        'btnRemovePoster
        '
        Me.btnRemovePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePoster.Image = CType(resources.GetObject("btnRemovePoster.Image"), System.Drawing.Image)
        Me.btnRemovePoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemovePoster.Location = New System.Drawing.Point(735, 363)
        Me.btnRemovePoster.Name = "btnRemovePoster"
        Me.btnRemovePoster.Size = New System.Drawing.Size(96, 83)
        Me.btnRemovePoster.TabIndex = 4
        Me.btnRemovePoster.Text = "Remove Poster"
        Me.btnRemovePoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemovePoster.UseVisualStyleBackColor = True
        '
        'lblPosterSize
        '
        Me.lblPosterSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPosterSize.Location = New System.Drawing.Point(8, 8)
        Me.lblPosterSize.Name = "lblPosterSize"
        Me.lblPosterSize.Size = New System.Drawing.Size(104, 23)
        Me.lblPosterSize.TabIndex = 0
        Me.lblPosterSize.Text = "Size: (XXXXxXXXX)"
        Me.lblPosterSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPosterSize.Visible = False
        '
        'btnSetPosterScrape
        '
        Me.btnSetPosterScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPosterScrape.Image = CType(resources.GetObject("btnSetPosterScrape.Image"), System.Drawing.Image)
        Me.btnSetPosterScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetPosterScrape.Location = New System.Drawing.Point(735, 93)
        Me.btnSetPosterScrape.Name = "btnSetPosterScrape"
        Me.btnSetPosterScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetPosterScrape.TabIndex = 2
        Me.btnSetPosterScrape.Text = "Change Poster (Scrape)"
        Me.btnSetPosterScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetPosterScrape.UseVisualStyleBackColor = True
        '
        'btnSetPoster
        '
        Me.btnSetPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPoster.Image = CType(resources.GetObject("btnSetPoster.Image"), System.Drawing.Image)
        Me.btnSetPoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetPoster.Location = New System.Drawing.Point(735, 6)
        Me.btnSetPoster.Name = "btnSetPoster"
        Me.btnSetPoster.Size = New System.Drawing.Size(96, 83)
        Me.btnSetPoster.TabIndex = 1
        Me.btnSetPoster.Text = "Change Poster (Local)"
        Me.btnSetPoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetPoster.UseVisualStyleBackColor = True
        '
        'pbPoster
        '
        Me.pbPoster.BackColor = System.Drawing.Color.DimGray
        Me.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPoster.Location = New System.Drawing.Point(6, 6)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(724, 440)
        Me.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPoster.TabIndex = 0
        Me.pbPoster.TabStop = False
        '
        'tpFanart
        '
        Me.tpFanart.Controls.Add(Me.lblFanartSize)
        Me.tpFanart.Controls.Add(Me.btnSetFanartDL)
        Me.tpFanart.Controls.Add(Me.btnRemoveFanart)
        Me.tpFanart.Controls.Add(Me.btnSetFanartScrape)
        Me.tpFanart.Controls.Add(Me.btnSetFanart)
        Me.tpFanart.Controls.Add(Me.pbFanart)
        Me.tpFanart.Location = New System.Drawing.Point(4, 22)
        Me.tpFanart.Name = "tpFanart"
        Me.tpFanart.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFanart.Size = New System.Drawing.Size(836, 452)
        Me.tpFanart.TabIndex = 6
        Me.tpFanart.Text = "Fanart"
        Me.tpFanart.UseVisualStyleBackColor = True
        '
        'lblFanartSize
        '
        Me.lblFanartSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFanartSize.Location = New System.Drawing.Point(8, 8)
        Me.lblFanartSize.Name = "lblFanartSize"
        Me.lblFanartSize.Size = New System.Drawing.Size(104, 23)
        Me.lblFanartSize.TabIndex = 0
        Me.lblFanartSize.Text = "Size: (XXXXxXXXX)"
        Me.lblFanartSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFanartSize.Visible = False
        '
        'btnSetFanartDL
        '
        Me.btnSetFanartDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetFanartDL.Image = CType(resources.GetObject("btnSetFanartDL.Image"), System.Drawing.Image)
        Me.btnSetFanartDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetFanartDL.Location = New System.Drawing.Point(735, 180)
        Me.btnSetFanartDL.Name = "btnSetFanartDL"
        Me.btnSetFanartDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetFanartDL.TabIndex = 3
        Me.btnSetFanartDL.Text = "Change Fanart (Download)"
        Me.btnSetFanartDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetFanartDL.UseVisualStyleBackColor = True
        '
        'btnRemoveFanart
        '
        Me.btnRemoveFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFanart.Image = CType(resources.GetObject("btnRemoveFanart.Image"), System.Drawing.Image)
        Me.btnRemoveFanart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveFanart.Location = New System.Drawing.Point(735, 363)
        Me.btnRemoveFanart.Name = "btnRemoveFanart"
        Me.btnRemoveFanart.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveFanart.TabIndex = 4
        Me.btnRemoveFanart.Text = "Remove Fanart"
        Me.btnRemoveFanart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveFanart.UseVisualStyleBackColor = True
        '
        'btnSetFanartScrape
        '
        Me.btnSetFanartScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetFanartScrape.Image = CType(resources.GetObject("btnSetFanartScrape.Image"), System.Drawing.Image)
        Me.btnSetFanartScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetFanartScrape.Location = New System.Drawing.Point(735, 93)
        Me.btnSetFanartScrape.Name = "btnSetFanartScrape"
        Me.btnSetFanartScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetFanartScrape.TabIndex = 2
        Me.btnSetFanartScrape.Text = "Change Fanart (Scrape)"
        Me.btnSetFanartScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetFanartScrape.UseVisualStyleBackColor = True
        '
        'btnSetFanart
        '
        Me.btnSetFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetFanart.Image = CType(resources.GetObject("btnSetFanart.Image"), System.Drawing.Image)
        Me.btnSetFanart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetFanart.Location = New System.Drawing.Point(735, 6)
        Me.btnSetFanart.Name = "btnSetFanart"
        Me.btnSetFanart.Size = New System.Drawing.Size(96, 83)
        Me.btnSetFanart.TabIndex = 1
        Me.btnSetFanart.Text = "Change Fanart (Local)"
        Me.btnSetFanart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetFanart.UseVisualStyleBackColor = True
        '
        'pbFanart
        '
        Me.pbFanart.BackColor = System.Drawing.Color.DimGray
        Me.pbFanart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFanart.Location = New System.Drawing.Point(6, 6)
        Me.pbFanart.Name = "pbFanart"
        Me.pbFanart.Size = New System.Drawing.Size(724, 440)
        Me.pbFanart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFanart.TabIndex = 30
        Me.pbFanart.TabStop = False
        '
        'tpFrameExtraction
        '
        Me.tpFrameExtraction.Controls.Add(Me.pnlFrameExtrator)
        Me.tpFrameExtraction.Location = New System.Drawing.Point(4, 22)
        Me.tpFrameExtraction.Name = "tpFrameExtraction"
        Me.tpFrameExtraction.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFrameExtraction.Size = New System.Drawing.Size(836, 452)
        Me.tpFrameExtraction.TabIndex = 3
        Me.tpFrameExtraction.Text = "Frame Extraction"
        Me.tpFrameExtraction.UseVisualStyleBackColor = True
        '
        'pnlFrameExtrator
        '
        Me.pnlFrameExtrator.Location = New System.Drawing.Point(1, 0)
        Me.pnlFrameExtrator.Name = "pnlFrameExtrator"
        Me.pnlFrameExtrator.Size = New System.Drawing.Size(834, 452)
        Me.pnlFrameExtrator.TabIndex = 0
        '
        'tpSubtitles
        '
        Me.tpSubtitles.Controls.Add(Me.lblSubtitlesPreview)
        Me.tpSubtitles.Controls.Add(Me.txtSubtitlesPreview)
        Me.tpSubtitles.Controls.Add(Me.lvSubtitles)
        Me.tpSubtitles.Controls.Add(Me.btnRemoveEpisodeSubtitle)
        Me.tpSubtitles.Controls.Add(Me.btnSetMovieSubtitleDL)
        Me.tpSubtitles.Controls.Add(Me.btnSetMovieSubtitleScrape)
        Me.tpSubtitles.Controls.Add(Me.btnSetMovieSubtitleLocal)
        Me.tpSubtitles.Location = New System.Drawing.Point(4, 22)
        Me.tpSubtitles.Name = "tpSubtitles"
        Me.tpSubtitles.Size = New System.Drawing.Size(836, 452)
        Me.tpSubtitles.TabIndex = 7
        Me.tpSubtitles.Text = "Subtitles"
        Me.tpSubtitles.UseVisualStyleBackColor = True
        '
        'lblSubtitlesPreview
        '
        Me.lblSubtitlesPreview.AutoSize = True
        Me.lblSubtitlesPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSubtitlesPreview.Location = New System.Drawing.Point(10, 292)
        Me.lblSubtitlesPreview.Name = "lblSubtitlesPreview"
        Me.lblSubtitlesPreview.Size = New System.Drawing.Size(51, 13)
        Me.lblSubtitlesPreview.TabIndex = 44
        Me.lblSubtitlesPreview.Text = "Preview:"
        '
        'txtSubtitlesPreview
        '
        Me.txtSubtitlesPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSubtitlesPreview.Location = New System.Drawing.Point(4, 308)
        Me.txtSubtitlesPreview.Multiline = True
        Me.txtSubtitlesPreview.Name = "txtSubtitlesPreview"
        Me.txtSubtitlesPreview.ReadOnly = True
        Me.txtSubtitlesPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSubtitlesPreview.Size = New System.Drawing.Size(726, 138)
        Me.txtSubtitlesPreview.TabIndex = 43
        '
        'lvSubtitles
        '
        Me.lvSubtitles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSubtitles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvSubtitles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lvSubtitles.FullRowSelect = True
        ListViewGroup1.Header = "Local Subtitles"
        ListViewGroup1.Name = "LocalSubtitles"
        Me.lvSubtitles.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvSubtitles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        ListViewItem1.Group = ListViewGroup1
        Me.lvSubtitles.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvSubtitles.Location = New System.Drawing.Point(6, 6)
        Me.lvSubtitles.MultiSelect = False
        Me.lvSubtitles.Name = "lvSubtitles"
        Me.lvSubtitles.Size = New System.Drawing.Size(724, 257)
        Me.lvSubtitles.TabIndex = 42
        Me.lvSubtitles.UseCompatibleStateImageBehavior = False
        Me.lvSubtitles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 25
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 550
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 100
        '
        'btnRemoveEpisodeSubtitle
        '
        Me.btnRemoveEpisodeSubtitle.Enabled = False
        Me.btnRemoveEpisodeSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveEpisodeSubtitle.Image = CType(resources.GetObject("btnRemoveEpisodeSubtitle.Image"), System.Drawing.Image)
        Me.btnRemoveEpisodeSubtitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveEpisodeSubtitle.Location = New System.Drawing.Point(735, 363)
        Me.btnRemoveEpisodeSubtitle.Name = "btnRemoveEpisodeSubtitle"
        Me.btnRemoveEpisodeSubtitle.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveEpisodeSubtitle.TabIndex = 41
        Me.btnRemoveEpisodeSubtitle.Text = "Remove Subtitle"
        Me.btnRemoveEpisodeSubtitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveEpisodeSubtitle.UseVisualStyleBackColor = True
        '
        'btnSetMovieSubtitleDL
        '
        Me.btnSetMovieSubtitleDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetMovieSubtitleDL.Image = CType(resources.GetObject("btnSetMovieSubtitleDL.Image"), System.Drawing.Image)
        Me.btnSetMovieSubtitleDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetMovieSubtitleDL.Location = New System.Drawing.Point(735, 180)
        Me.btnSetMovieSubtitleDL.Name = "btnSetMovieSubtitleDL"
        Me.btnSetMovieSubtitleDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetMovieSubtitleDL.TabIndex = 40
        Me.btnSetMovieSubtitleDL.Text = "Add Subtitle (Download)"
        Me.btnSetMovieSubtitleDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetMovieSubtitleDL.UseVisualStyleBackColor = True
        '
        'btnSetMovieSubtitleScrape
        '
        Me.btnSetMovieSubtitleScrape.Enabled = False
        Me.btnSetMovieSubtitleScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetMovieSubtitleScrape.Image = CType(resources.GetObject("btnSetMovieSubtitleScrape.Image"), System.Drawing.Image)
        Me.btnSetMovieSubtitleScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetMovieSubtitleScrape.Location = New System.Drawing.Point(735, 93)
        Me.btnSetMovieSubtitleScrape.Name = "btnSetMovieSubtitleScrape"
        Me.btnSetMovieSubtitleScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetMovieSubtitleScrape.TabIndex = 39
        Me.btnSetMovieSubtitleScrape.Text = "Add Subtitle (Scrape)"
        Me.btnSetMovieSubtitleScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetMovieSubtitleScrape.UseVisualStyleBackColor = True
        '
        'btnSetMovieSubtitleLocal
        '
        Me.btnSetMovieSubtitleLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetMovieSubtitleLocal.Image = CType(resources.GetObject("btnSetMovieSubtitleLocal.Image"), System.Drawing.Image)
        Me.btnSetMovieSubtitleLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetMovieSubtitleLocal.Location = New System.Drawing.Point(735, 6)
        Me.btnSetMovieSubtitleLocal.Name = "btnSetMovieSubtitleLocal"
        Me.btnSetMovieSubtitleLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetMovieSubtitleLocal.TabIndex = 38
        Me.btnSetMovieSubtitleLocal.Text = "Add Subtitle (Local Browse)"
        Me.btnSetMovieSubtitleLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetMovieSubtitleLocal.UseVisualStyleBackColor = True
        '
        'tpMetaData
        '
        Me.tpMetaData.Controls.Add(Me.pnlFileInfo)
        Me.tpMetaData.Location = New System.Drawing.Point(4, 22)
        Me.tpMetaData.Name = "tpMetaData"
        Me.tpMetaData.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMetaData.Size = New System.Drawing.Size(836, 452)
        Me.tpMetaData.TabIndex = 5
        Me.tpMetaData.Text = "Meta Data"
        Me.tpMetaData.UseVisualStyleBackColor = True
        '
        'pnlFileInfo
        '
        Me.pnlFileInfo.Location = New System.Drawing.Point(-4, 0)
        Me.pnlFileInfo.Name = "pnlFileInfo"
        Me.pnlFileInfo.Size = New System.Drawing.Size(844, 452)
        Me.pnlFileInfo.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(775, 553)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(702, 553)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'chkWatched
        '
        Me.chkWatched.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkWatched.AutoSize = True
        Me.chkWatched.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWatched.Location = New System.Drawing.Point(12, 557)
        Me.chkWatched.Name = "chkWatched"
        Me.chkWatched.Size = New System.Drawing.Size(72, 17)
        Me.chkWatched.TabIndex = 7
        Me.chkWatched.Text = "Watched"
        Me.chkWatched.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFilename})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(854, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'tsFilename
        '
        Me.tsFilename.Name = "tsFilename"
        Me.tsFilename.Size = New System.Drawing.Size(55, 17)
        Me.tsFilename.Text = "Filename"
        '
        'txtLastPlayed
        '
        Me.txtLastPlayed.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastPlayed.Enabled = False
        Me.txtLastPlayed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtLastPlayed.Location = New System.Drawing.Point(96, 552)
        Me.txtLastPlayed.Name = "txtLastPlayed"
        Me.txtLastPlayed.Size = New System.Drawing.Size(118, 22)
        Me.txtLastPlayed.TabIndex = 75
        '
        'dlgEditTVEpisode
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(854, 601)
        Me.Controls.Add(Me.txtLastPlayed)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.chkWatched)
        Me.Controls.Add(Me.tcEdit)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEditTVEpisode"
        Me.Text = "Edit Episode"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pbTopLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEdit.ResumeLayout(False)
        Me.tpDetails.ResumeLayout(False)
        Me.tpDetails.PerformLayout()
        CType(Me.pbStar10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPoster.ResumeLayout(False)
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFanart.ResumeLayout(False)
        CType(Me.pbFanart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFrameExtraction.ResumeLayout(False)
        Me.tpSubtitles.ResumeLayout(False)
        Me.tpSubtitles.PerformLayout()
        Me.tpMetaData.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTopDetails As System.Windows.Forms.Label
    Friend WithEvents lblTopTitle As System.Windows.Forms.Label
    Friend WithEvents pbTopLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tcEdit As System.Windows.Forms.TabControl
    Friend WithEvents tpDetails As System.Windows.Forms.TabPage
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents btnEditActor As System.Windows.Forms.Button
    Friend WithEvents btnAddActor As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblActors As System.Windows.Forms.Label
    Friend WithEvents lvActors As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRole As System.Windows.Forms.ColumnHeader
    Friend WithEvents colThumb As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDirector As System.Windows.Forms.Label
    Friend WithEvents txtDirector As System.Windows.Forms.TextBox
    Friend WithEvents lblPlot As System.Windows.Forms.Label
    Friend WithEvents txtPlot As System.Windows.Forms.TextBox
    Friend WithEvents pbStar5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents lblAired As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents tpPoster As System.Windows.Forms.TabPage
    Friend WithEvents btnSetPosterDL As System.Windows.Forms.Button
    Friend WithEvents btnRemovePoster As System.Windows.Forms.Button
    Friend WithEvents lblPosterSize As System.Windows.Forms.Label
    Friend WithEvents btnSetPosterScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetPoster As System.Windows.Forms.Button
    Friend WithEvents pbPoster As System.Windows.Forms.PictureBox
    Friend WithEvents tpFrameExtraction As System.Windows.Forms.TabPage
    Friend WithEvents tpMetaData As System.Windows.Forms.TabPage
    Friend WithEvents pnlFileInfo As System.Windows.Forms.Panel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtEpisode As System.Windows.Forms.TextBox
    Friend WithEvents lblEpisode As System.Windows.Forms.Label
    Friend WithEvents txtSeason As System.Windows.Forms.TextBox
    Friend WithEvents lblSeason As System.Windows.Forms.Label
    Friend WithEvents tpFanart As System.Windows.Forms.TabPage
    Friend WithEvents btnSetFanartDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFanart As System.Windows.Forms.Button
    Friend WithEvents btnSetFanartScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetFanart As System.Windows.Forms.Button
    Friend WithEvents pbFanart As System.Windows.Forms.PictureBox
    Friend WithEvents lblFanartSize As System.Windows.Forms.Label
    Friend WithEvents txtAired As System.Windows.Forms.TextBox
    Friend WithEvents btnActorDown As System.Windows.Forms.Button
    Friend WithEvents btnActorUp As System.Windows.Forms.Button
    Friend WithEvents pnlFrameExtrator As System.Windows.Forms.Panel
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkWatched As System.Windows.Forms.CheckBox
    Friend WithEvents pbStar10 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar9 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRuntime As System.Windows.Forms.Label
    Friend WithEvents txtRuntime As System.Windows.Forms.TextBox
    Friend WithEvents txtVotes As System.Windows.Forms.TextBox
    Friend WithEvents lblVotes As System.Windows.Forms.Label
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tsFilename As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtVideoSource As System.Windows.Forms.TextBox
    Friend WithEvents lblVideoSource As System.Windows.Forms.Label
    Friend WithEvents tpSubtitles As System.Windows.Forms.TabPage
    Friend WithEvents lblSubtitlesPreview As System.Windows.Forms.Label
    Friend WithEvents txtSubtitlesPreview As System.Windows.Forms.TextBox
    Friend WithEvents lvSubtitles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveEpisodeSubtitle As System.Windows.Forms.Button
    Friend WithEvents btnSetMovieSubtitleDL As System.Windows.Forms.Button
    Friend WithEvents btnSetMovieSubtitleScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetMovieSubtitleLocal As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtLastPlayed As System.Windows.Forms.TextBox

End Class
