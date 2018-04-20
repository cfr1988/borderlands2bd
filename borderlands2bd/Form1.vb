Imports MySql.Data.MySqlClient

Public Class Form1

    'pantalla completa

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

    'variables conexion bd mysql
    Dim conexion As New MySqlConnection()
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter

    'búsqueda armas por nombre y borrado previo
    Private Sub buscaArma(sender As Object, e As EventArgs) Handles btnBuscaNombre.Click


        If DiseñoArma.Visible = True Then

            DiseñoArma.Visible = False

        End If

        Try

            conexion.ConnectionString = "server=localhost; user=root;password=;database=borderlands2"
            conexion.Open()

            'consulta específica 
            Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreArma.Text + "%' AND tipo NOT LIKE 'escudo' AND tipo NOT LIKE 'modificador'
                                                                                                                AND tipo NOT LIKE 'granada' AND tipo NOT LIKE 'reliquia'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaArmas.DataSource = datos
            tablaArmas.DataMember = "equipo"

            tablaArmas.Visible = True
            tablaArmas.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'búsqueda avanzada de armas y borrado previo
    Private Sub armasAvanzadas(sender As Object, e As EventArgs) Handles btnArmasAvanzadas.Click

        Try

            If txtNombreArma IsNot "" Then

                txtNombreArma.Clear()

                If DiseñoArma.Visible = True Then

                    DiseñoArma.Visible = False

                End If

            End If


            If cmbColorArma.SelectedIndex = -1 Or cmbTipoArma.SelectedIndex = -1 Then

                'si no se especifican campos requeridos
                MessageBox.Show("debe de seleccionar cada una de las opciones del recuadro para iniciar la búsqueda avanzada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            Else

                conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
                conexion.Open()

                'consulta específica
                Dim consulta As String = "SELECT * FROM equipo WHERE color LIKE '" + cmbColorArma.SelectedItem + "' AND tipo LIKE '" + cmbTipoArma.SelectedItem + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()

            End If

        Catch ex As Exception

        End Try

    End Sub

    'búsqueda armas mediante enter y borrado previo
    Private Sub enter(sender As Object, e As KeyPressEventArgs) Handles txtNombreArma.KeyPress

        If Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then

            If DiseñoArma.Visible = True Then

                DiseñoArma.Visible = False

            End If

            Try

                conexion.ConnectionString = "server=localhost; user=root;password=;database=borderlands2"
                conexion.Open()

                Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreArma.Text + "%' AND tipo NOT LIKE 'escudo' AND tipo NOT LIKE 'modificador'
                                                                                                                AND tipo NOT LIKE 'granada' AND tipo NOT LIKE 'reliquia'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True

                conexion.Close()
                GC.Collect()

            Catch ex As Exception

            End Try
        End If
    End Sub

    'Busqueda de armas según enemigos y borrado previo
    Private Sub ListaJefes(sender As Object, e As EventArgs) Handles lbEnemArmas.Click

        If DiseñoArma.Visible = True Then

            DiseñoArma.Visible = False

        End If

        If txtNombreArma.Text IsNot "" Then

            txtNombreArma.Text = ""

        End If

        lbMisionArmas.ClearSelected()
        lbArmaUbica.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost ;user=root; password=; database=borderlands2"
            conexion.Open()


            If lbEnemArmas.SelectedItem IsNot "Slappy" Then

                'consulta específica
                Dim consultalista As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbEnemArmas.SelectedItem + "%' And tipo NOT LIKE 'escudo' AND tipo NOT LIKE 'modificador'
                                                                                                                AND tipo NOT LIKE 'granada' AND tipo NOT LIKE 'reliquia'"

                adaptador = New MySqlDataAdapter(consultalista, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()

            Else

                'consulta específica
                Dim consultaslap As String = "SELECT * FROM equipo WHERE nombre like 'Striker'"

                adaptador = New MySqlDataAdapter(consultaslap, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()


            End If

        Catch ex As Exception

        End Try

    End Sub

    'busqueda de armas por mision especifica y borrado previo
    Private Sub lsArmasMision(sender As Object, e As EventArgs) Handles lbMisionArmas.Click

        If DiseñoArma.Visible = True Then

            DiseñoArma.Visible = False

        End If

        If txtNombreArma.Text IsNot "" Then

            txtNombreArma.Text = ""

        End If

        lbEnemArmas.ClearSelected()
        lbArmaUbica.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            If lbMisionArmas.SelectedItem Is "guerra entre clanes" Then

                'consulta específica
                Dim armaMision As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbMisionArmas.SelectedItem + "%' AND tipo NOT LIKE 'escudo'"

                adaptador = New MySqlDataAdapter(armaMision, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()


            Else

                'consulta específica
                Dim armaMision As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbMisionArmas.SelectedItem + "%' AND tipo NOT like 'escudo'"

                adaptador = New MySqlDataAdapter(armaMision, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()

            End If

        Catch ex As Exception

        End Try

    End Sub

    'busqueda arma ubicacion especifica y borrado previo
    Private Sub armaUbicacion(sender As Object, e As EventArgs) Handles lbArmaUbica.Click

        If DiseñoArma.Visible = True Then

            DiseñoArma.Visible = False

        End If

        If txtNombreArma.Text IsNot "" Then

            txtNombreArma.Text = ""

        End If

        lbEnemArmas.ClearSelected()
        lbMisionArmas.ClearSelected()


        conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
        conexion.Open()

        Try

            If lbArmaUbica.SelectedItem Is "The Dust" Then

                'consulta
                Dim consultaUbica As String = "SELECT * FROM equipo WHERE localizacion like ""%ubicaciones diferentes%"""

                adaptador = New MySqlDataAdapter(consultaUbica, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False


                conexion.Close()
                GC.Collect()

            Else

                'consulta
                Dim consultaUbica As String = "SELECT * FROM equipo WHERE nombre like ""Lascaux"""

                adaptador = New MySqlDataAdapter(consultaUbica, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaArmas.DataSource = datos
                tablaArmas.DataMember = "equipo"

                tablaArmas.Visible = True
                tablaArmas.CurrentRow.Selected = False


                conexion.Close()
                GC.Collect()

            End If

        Catch ex As Exception

        End Try

    End Sub

    'borrado armas
    Private Sub borraArmas(sender As Object, e As EventArgs) Handles btnBorraArma.Click

        tablaArmas.Visible = False
        txtNombreArma.Clear()
        DiseñoArma.Visible = False

        cmbTipoArma.SelectedIndex = -1
        cmbColorArma.SelectedIndex = -1

        While lbEnemArmas.SelectedIndex >= 0

            lbEnemArmas.SelectedIndex = -1

        End While

        While lbMisionArmas.SelectedIndex >= 0

            lbMisionArmas.SelectedIndex = -1

        End While

        While lbArmaUbica.SelectedIndex >= 0

            lbArmaUbica.SelectedIndex = -1

        End While

    End Sub

    'búsqueda de escudo por texto y borrado previo
    Private Sub BuscaEscudo_Click(sender As Object, e As EventArgs) Handles btnBuscaEscudo.Click

        If DiseñoEscudo.Visible = True Then

            DiseñoEscudo.Visible = False

        End If

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta específica
            Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreEscudo.Text + "%' AND tipo like 'escudo'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaEscudos.DataSource = datos
            tablaEscudos.DataMember = "equipo"

            tablaEscudos.Visible = True
            tablaArmas.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()


        Catch ex As Exception

        End Try

    End Sub

    'búsqueda de escudo específica y borrado previo
    Private Sub ColorEscudo_Click(sender As Object, e As EventArgs) Handles btnColorEscudo.Click

        Try

            If txtNombreEscudo IsNot "" Then

                txtNombreEscudo.Clear()

                If DiseñoEscudo.Visible = True Then

                    DiseñoEscudo.Visible = False

                End If

            End If

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta específica
            Dim consulta As String = "Select * FROM equipo WHERE color LIKE '" + cmbColorEscudo.SelectedItem + "' AND tipo like 'escudo'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaEscudos.DataSource = datos
            tablaEscudos.DataMember = "equipo"

            tablaEscudos.Visible = True
            tablaEscudos.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'busqueda escudo mediante enter y borrado previo
    Private Sub enterEscudo(sender As Object, e As KeyPressEventArgs) Handles txtNombreEscudo.KeyPress

        If Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then

            If DiseñoEscudo.Visible = True Then

                DiseñoEscudo.Visible = False

            End If

            Try

                conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
                conexion.Open()

                Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreEscudo.Text + "%' AND tipo like 'escudo'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaEscudos.DataSource = datos
                tablaEscudos.DataMember = "equipo"

                tablaEscudos.Visible = True

                conexion.Close()
                GC.Collect()


            Catch ex As Exception

            End Try

        End If

    End Sub

    'busqueda escudo por enemigos y borrado previo
    Private Sub ListaEnemigosEscudo(sender As Object, e As EventArgs) Handles lbEnemEscudo.Click

        If DiseñoEscudo.Visible = True Then

            DiseñoEscudo.Visible = False

        End If

        If txtNombreEscudo.Text IsNot "" Then

            txtNombreEscudo.Text = ""

        End If

        lbEscudoMision.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta
            Dim consultalistaescudo As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbEnemEscudo.SelectedItem + "%' AND tipo LIKE 'escudo'"

            adaptador = New MySqlDataAdapter(consultalistaescudo, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaEscudos.DataSource = datos
            tablaEscudos.DataMember = "equipo"

            tablaEscudos.Visible = True
            tablaEscudos.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'busqueda escudo por mision y borrado previo
    Private Sub lbmisionEscudo(sender As Object, e As EventArgs) Handles lbEscudoMision.Click

        If DiseñoEscudo.Visible = True Then

            DiseñoEscudo.Visible = False

        End If

        If txtNombreEscudo.Text IsNot "" Then

            txtNombreEscudo.Text = ""

        End If

        lbEnemEscudo.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta
            If lbEscudoMision.SelectedItem Is "guerra entre clanes" Then

                Dim Misionescudo As String = "SELECT * FROM equipo WHERE nombre like 'Aequitas'"

                adaptador = New MySqlDataAdapter(Misionescudo, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaEscudos.DataSource = datos
                tablaEscudos.DataMember = "equipo"

                tablaEscudos.Visible = True
                tablaEscudos.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()


            Else

                'consulta
                Dim MisionEscudo As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbEscudoMision.SelectedItem + "%' AND tipo like 'escudo'"

                adaptador = New MySqlDataAdapter(MisionEscudo, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaEscudos.DataSource = datos
                tablaEscudos.DataMember = "equipo"

                tablaEscudos.Visible = True
                tablaEscudos.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()


            End If

        Catch ex As Exception

        End Try

    End Sub

    'borrado escudo
    Private Sub BorraEscudo_Click(sender As Object, e As EventArgs) Handles btnBorraEscudo.Click

        tablaEscudos.Visible = False
        txtNombreEscudo.Clear()
        DiseñoEscudo.Visible = False

        cmbColorEscudo.SelectedIndex = -1

        While lbEnemEscudo.SelectedIndex >= 0

            lbEnemEscudo.SelectedIndex = -1
        End While

        While lbEscudoMision.SelectedIndex >= 0

            lbEscudoMision.SelectedIndex = -1

        End While


    End Sub

    'búsqueda modificador por nombre y borrado previo
    Private Sub btnNombreMod_Click(sender As Object, e As EventArgs)

        If DiseñoMod.Visible = True Then

            DiseñoMod.Visible = False

        End If

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            Dim consulta As String = "SELECT * FROM modificadores WHERE nombre LIKE '%" + txtNombreMod.Text + "%'"

            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "modificadores")
            tablaModificador.DataSource = datos
            tablaModificador.DataMember = "modificadores"

            tablaModificador.Visible = True
            conexion.Close()
            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'busqueda modificador específico y borrado previo
    Private Sub enterMod(sender As Object, e As KeyPressEventArgs) Handles txtNombreMod.KeyPress

        If Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then

            If DiseñoMod.Visible = True Then

                DiseñoMod.Visible = False


            End If

            Try

                conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
                conexion.Open()

                Dim consulta As String = "SELECT * FROM modificadores WHERE nombre LIKE '%" + txtNombreMod.Text + "%'"

                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True
                conexion.Close()
                GC.Collect()

            Catch ex As Exception

            End Try

        End If

    End Sub

    'busqueda modificador especifico y borrado previo
    Private Sub ColorPjMod_Click(sender As Object, e As EventArgs) Handles btnColorMod.Click

        If DiseñoMod.Visible = True Then

            DiseñoMod.Visible = False

        End If

        If rbAxton.Checked = False And rbGaige.Checked = False And rbKrieg.Checked = False And
            rbSalvador.Checked = False And rbMaya.Checked = False And rbZero.Checked = False Or cmbColorModificador.SelectedIndex < 0 Then

            MsgBox("faltan por marcar", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub

        End If

        Dim consulta1 As String
        Dim consulta2 As String
        Dim consulta3 As String
        Dim consulta4 As String
        Dim consulta5 As String
        Dim consulta6 As String
        Dim consulta7 As String

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            If rbAxton.Checked = True And cmbColorModificador.SelectedIndex >= 0 Then

                consulta1 = "SELECT * FROM modificadores WHERE personaje LIKE '" + rbAxton.Text + "' AND color LIKE '" + cmbColorModificador.SelectedItem + "'"

                adaptador = New MySqlDataAdapter(consulta1, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True

                conexion.Close()
                GC.Collect()


            ElseIf rbMaya.Checked = True And cmbColorModificador.SelectedIndex >= 0 Then

                consulta2 = "SELECT * FROM modificadores WHERE personaje LIKE '" + rbMaya.Text + "' AND color LIKE '" + cmbColorModificador.SelectedItem + "'"

                adaptador = New MySqlDataAdapter(consulta2, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True

                conexion.Close()
                GC.Collect()


            ElseIf rbSalvador.Checked = True And cmbColorModificador.SelectedIndex >= 0 Then

                consulta3 = "SELECT * FROM modificadores WHERE personaje LIKE '" + rbSalvador.Text + "' AND color LIKE '" + cmbColorModificador.SelectedItem + "'"

                adaptador = New MySqlDataAdapter(consulta3, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True

                conexion.Close()
                GC.Collect()


            ElseIf rbZero.Checked = True And cmbColorModificador.SelectedIndex >= 0 Then

                consulta4 = "SELECT * FROM modificadores WHERE personaje LIKE '" + rbZero.Text + "' AND color LIKE '" + cmbColorModificador.SelectedItem + "'"

                adaptador = New MySqlDataAdapter(consulta4, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True

                conexion.Close()
                GC.Collect()


            ElseIf rbGaige.Checked = True And cmbColorModificador.SelectedIndex >= 0 Then

                consulta5 = "SELECT * FROM modificadores WHERE personaje LIKE '" + rbGaige.Text + "' AND color LIKE '" + cmbColorModificador.SelectedItem + "'"

                adaptador = New MySqlDataAdapter(consulta5, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True

                conexion.Close()
                GC.Collect()


            ElseIf rbKrieg.Checked = True And cmbColorModificador.SelectedIndex >= 0 Then

                consulta6 = "SELECT * FROM modificadores WHERE personaje LIKE '" + rbKrieg.Text + "' AND color LIKE '" + cmbColorModificador.SelectedItem + "'"

                adaptador = New MySqlDataAdapter(consulta6, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "modificadores")
                tablaModificador.DataSource = datos
                tablaModificador.DataMember = "modificadores"

                tablaModificador.Visible = True

                conexion.Close()
                GC.Collect()

            End If

        Catch ex As Exception

        End Try

    End Sub

    'borrado
    Private Sub borraMod(sender As Object, e As EventArgs) Handles btnBorraMod.Click

        txtNombreMod.Clear()
        tablaModificador.Visible = False
        DiseñoMod.Visible = False

        cmbColorModificador.SelectedIndex = -1

        For Each ctrl As Control In gpMod.Controls

            If TypeOf ctrl Is RadioButton Then

                DirectCast(ctrl, RadioButton).Checked = False

            End If

        Next

        While lbMod.SelectedIndex >= 0

            lbMod.SelectedIndex = -1

        End While


    End Sub

    'busqueda de granada por nombre y borrado previo

    Private Sub nombreGranada_Click(sender As Object, e As EventArgs) Handles btnBuscaGranada.Click

        If DiseñoGranada.Visible = True Then

            DiseñoGranada.Visible = False

        End If

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta específica
            Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreGranada.Text + "%' AND tipo LIKE 'granada'"

            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaGranadas.DataSource = datos
            tablaGranadas.DataMember = "equipo"

            tablaGranadas.Visible = True
            tablaGranadas.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'búsqueda de granada específica y borrado previo
    Private Sub ColorGranada_Click(sender As Object, e As EventArgs) Handles btnColorGranada.Click

        If DiseñoGranada.Visible = True Then

            DiseñoGranada.Visible = False

        End If

        Try

            conexion.ConnectionString = "server= localhost; user= root; password=; database= borderlands2"
            conexion.Open()

            'consulta específica
            Dim consulta As String = "SELECT * FROM equipo WHERE color LIKE '" + cmbColorGranada.SelectedItem + "' AND tipo LIKE 'granada'"

            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaGranadas.DataSource = datos
            tablaGranadas.DataMember = "equipo"

            tablaGranadas.Visible = True
            conexion.Close()

            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'busqueda granada mediante enter y borrado previo
    Private Sub enterGranada(sender As Object, e As KeyPressEventArgs) Handles txtNombreGranada.KeyPress

        If Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then

            If DiseñoGranada.Visible = True Then

                DiseñoGranada.Visible = False

            End If

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreGranada.Text + "%' AND tipo LIKE 'granada'"

            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaGranadas.DataSource = datos
            tablaGranadas.DataMember = "equipo"

            tablaGranadas.Visible = True

            conexion.Close()
            GC.Collect()

        End If

    End Sub

    'búsqueda granada por enemigo y borrado previo
    Private Sub lsGranadaEnemigo(sender As Object, e As EventArgs) Handles lbGrEnemigo.Click

        If DiseñoGranada.Visible = True Then

            DiseñoGranada.Visible = False

        End If

        If txtNombreGranada.Text IsNot "" Then

            txtNombreGranada.Text = ""

        End If

        lbGrMision.ClearSelected()

        conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
        conexion.Open()

        Try

            'consulta
            Dim GranadaEnemigo As String = "SELECT * FROM equipo WHERE localizacion like'%" + lbGrEnemigo.SelectedItem + "%' AND tipo like 'granada'"
            adaptador = New MySqlDataAdapter(GranadaEnemigo, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaGranadas.DataSource = datos
            tablaGranadas.DataMember = "equipo"

            tablaGranadas.Visible = True
            tablaGranadas.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()


        Catch ex As Exception

        End Try

    End Sub

    'busqueda granada por mision y borrado previo
    Private Sub lbGranadMision(sender As Object, e As EventArgs) Handles lbGrMision.Click

        If DiseñoGranada.Visible = True Then

            DiseñoGranada.Visible = False

        End If

        If txtNombreGranada.Text IsNot "" Then

            txtNombreGranada.Text = ""

        End If

        lbGrEnemigo.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            If lbGrMision.SelectedItem Is "guerra entre clanes" Then

                'consulta
                Dim GranadaMision As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbGrMision.SelectedItem + "%' AND tipo like 'granada'"
                adaptador = New MySqlDataAdapter(GranadaMision, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaGranadas.DataSource = datos
                tablaGranadas.DataMember = "equipo"

                tablaGranadas.Visible = True
                tablaGranadas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()



            Else

                'consulta
                Dim GranadaMision As String = "SELECT * FROM equipo WHERE localizacion like '%" + lbGrMision.SelectedItem + "%' AND tipo like 'granada'"
                adaptador = New MySqlDataAdapter(GranadaMision, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaGranadas.DataSource = datos
                tablaGranadas.DataMember = "equipo"

                tablaGranadas.Visible = True
                tablaGranadas.CurrentRow.Selected = False

                conexion.Close()
                GC.Collect()

            End If

        Catch ex As Exception

        End Try

    End Sub

    'borrado granada
    Private Sub BorraGranada_Click(sender As Object, e As EventArgs) Handles btnBorraGranada.Click

        tablaGranadas.Visible = False
        txtNombreGranada.Clear()
        DiseñoGranada.Visible = False

        cmbColorGranada.SelectedIndex = -1

        While lbGrEnemigo.SelectedIndex >= 0

            lbGrEnemigo.SelectedIndex = -1

        End While

        While lbGrMision.SelectedIndex >= 0

            lbGrMision.SelectedIndex = -1

        End While

    End Sub

    'busqueda reliquia por nombre y borrado previo
    Private Sub BuscaReliquia_Click(sender As Object, e As EventArgs) Handles btnBuscaReliquia.Click

        If DiseñoReliquia.Visible = True Then

            DiseñoReliquia.Visible = False


        End If

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta específica
            Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreReliquia.Text + "%' AND tipo LIKE 'reliquia'"

            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaReliquia.DataSource = datos
            tablaReliquia.DataMember = "equipo"

            tablaReliquia.Visible = True
            conexion.Close()

            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    'busqueda reliquia específica y borrado previo
    Private Sub btnColorReliquia_Click(sender As Object, e As EventArgs) 

        If txtNombreReliquia IsNot "" Then

            txtNombreReliquia.Clear()

        End If

        Try
            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta específica
            Dim consulta As String = "SELECT * FROM equipo WHERE color LIKE '" + cmbColorReliqua.SelectedItem + "' AND tipo LIKE 'reliquia'"

            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaReliquia.DataSource = datos
            tablaReliquia.DataMember = "equipo"

            tablaReliquia.Visible = True
            conexion.Close()

            GC.Collect()

        Catch ex As Exception

        End Try


    End Sub

    'busqueda reliquia mediante enter y borrado previo
    Private Sub enterReliquia(sender As Object, e As KeyPressEventArgs) Handles txtNombreReliquia.KeyPress

        If Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then

            If DiseñoReliquia.Visible = True Then

                DiseñoReliquia.Visible = False

            End If

            Try

                conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
                conexion.Open()

                Dim consulta As String = "SELECT * FROM equipo WHERE nombre LIKE '%" + txtNombreReliquia.Text + "%' AND tipo LIKE 'reliquia'"

                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "equipo")
                tablaReliquia.DataSource = datos
                tablaReliquia.DataMember = "equipo"

                tablaReliquia.Visible = True
                conexion.Close()

                GC.Collect()

            Catch ex As Exception

            End Try

        End If

    End Sub

    'mostrado de imagen correspondiente según busqueda
    'algunas tienen instrucciones específicas debido a similitudes
    Private Sub muestraImagen(sender As Object, e As DataGridViewCellEventArgs) Handles tablaArmas.CellClick


        'imagen de armas
        If tablaArmas.CurrentRow.Cells(0).Value.ToString().Contains("Stalker Shotgun") Then

            DiseñoArma.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Stalker Shotgun.jpg")
            DiseñoArma.Visible = True


        Else

            DiseñoArma.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\" + tablaArmas.CurrentRow.Cells(0).Value + ".jpg")
            DiseñoArma.Visible = True

        End If

        If tablaArmas.CurrentRow.Cells(0).Value.ToString().Contains("Storm") And tablaArmas.CurrentRow.Cells(3).Value.ToString().Contains("smg") Then

            DiseñoArma.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Storm (Smg).jpg")
            DiseñoArma.Visible = True


        End If

    End Sub

    Private Sub mostrarEscudo(sender As Object, e As DataGridViewCellEventArgs) Handles tablaEscudos.CellClick

        'imagen de escudos

        DiseñoEscudo.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\" + tablaEscudos.CurrentRow.Cells(0).Value + ".jpg")
        DiseñoEscudo.Visible = True

    End Sub

    Private Sub mostrarGranada(sender As Object, e As DataGridViewCellEventArgs) Handles tablaGranadas.CellClick

        'imagen de granadas

        DiseñoGranada.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\" + tablaGranadas.CurrentRow.Cells(0).Value + ".jpg")
        DiseñoGranada.Visible = True

    End Sub

    Private Sub mostrarReliquia(sender As Object, e As DataGridViewCellEventArgs) Handles tablaReliquia.CellClick

        'imagen de reliquias

        DiseñoReliquia.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\" + tablaReliquia.CurrentRow.Cells(0).Value + ".jpg")
        DiseñoReliquia.Visible = True

    End Sub

    Private Sub MostrarMod(sender As Object, e As DataGridViewCellEventArgs) Handles tablaModificador.CellClick

        'imagen de modificadores

        If tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Devastator") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Devastatormod.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Renegade") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Renegademod.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Fox") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Foxmod.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Legendary Anarchist") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\LegendaryAnarchist.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Anarchist") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Anarchistmod.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Legendary Sniper") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Legendary Sniper.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Sniper") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Snipermod.jpg")
            DiseñoMod.Visible = True

        ElseIf tablaModificador.CurrentRow.Cells(0).Value.ToString().Contains("Stalker") Then

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\Stalkermod.jpg")
            DiseñoMod.Visible = True


        Else

            DiseñoMod.Image = Image.FromFile("C:\Users\carlos\source\repos\borderlands2bd\borderlands2bd\img\" + tablaModificador.CurrentRow.Cells(0).Value + ".jpg")
            DiseñoMod.Visible = True

        End If

    End Sub



    'busqueda reliquia por enemigo y borrado previo
    Private Sub lsRelEnemigo(sender As Object, e As EventArgs) Handles lbRelEnemigo.Click

        If DiseñoReliquia.Visible = True Then

            DiseñoReliquia.Visible = False

        End If

        If txtNombreReliquia.Text IsNot "" Then

            txtNombreReliquia.Text = ""

        End If

        lbRelMision.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            'consulta
            Dim RelEnemigo As String = "SELECT * FROM equipo WHERE localizacion like'%" + lbRelEnemigo.SelectedItem + "%' AND tipo LIKE 'reliquia'"

            adaptador = New MySqlDataAdapter(RelEnemigo, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaReliquia.DataSource = datos
            tablaReliquia.DataMember = "equipo"

            tablaReliquia.Visible = True
            tablaReliquia.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()


        Catch ex As Exception

        End Try

    End Sub

    'busqueda reliquia por mision y borrado previo
    Private Sub lbMisionReliquia(sender As Object, e As EventArgs) Handles lbRelMision.Click

        If DiseñoReliquia.Visible = True Then

            DiseñoReliquia.Visible = False

        End If

        If txtNombreReliquia.Text IsNot "" Then

            txtNombreReliquia.Text = ""

        End If

        lbRelEnemigo.ClearSelected()

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database=borderlands2"
            conexion.Open()

            Dim ReliquiaMision As String = "SELECT * FROM equipo WHERE localizacion LIKE '%" + lbRelMision.SelectedItem + "%' AND tipo LIKE 'reliquia'"
            adaptador = New MySqlDataAdapter(ReliquiaMision, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "equipo")
            tablaReliquia.DataSource = datos
            tablaReliquia.DataMember = "equipo"

            tablaReliquia.Visible = True
            tablaReliquia.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()



        Catch ex As Exception

        End Try

    End Sub

    'borrado
    Private Sub BorraReliq(sender As Object, e As EventArgs) Handles btnBorraReliquia.Click

        txtNombreReliquia.Clear()
        tablaReliquia.Visible = False
        DiseñoReliquia.Visible = False

        cmbColorReliqua.SelectedIndex = -1

        While lbRelEnemigo.SelectedIndex >= 0

            lbRelEnemigo.SelectedIndex = -1

        End While

        While lbRelMision.SelectedIndex >= 0

            lbRelMision.SelectedIndex = -1

        End While

    End Sub



    'busqueda modificador por enemigos y borrado previo
    Private Sub EnemMod(sender As Object, e As EventArgs) Handles lbMod.Click

        If DiseñoMod.Visible = True Then

            DiseñoMod.Visible = False

        End If

        If txtNombreMod.Text IsNot "" Then

            txtNombreMod.Text = ""

        End If

        Try

            conexion.ConnectionString = "server=localhost; user=root; password=; database= borderlands2"
            conexion.Open()

            'consulta
            Dim EnemigoMod As String = "SELECT * FROM modificadores WHERE obtencion like '%" + lbMod.SelectedItem + "%'"
            adaptador = New MySqlDataAdapter(EnemigoMod, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "modificadores")
            tablaModificador.DataSource = datos
            tablaModificador.DataMember = "modificadores"

            tablaModificador.Visible = True
            tablaModificador.CurrentRow.Selected = False

            conexion.Close()
            GC.Collect()


        Catch ex As Exception

        End Try
    End Sub

    'borrado de controladores de pestañas mediante objeto control
    'al cambiar a otra pestaña diferente, se borran los datos de los controladores de la anterior pestaña
    Private Sub borradoTabs(sender As Object, e As EventArgs) Handles tabPane.Click

        If tabPane.SelectedTab Is tabArmas Then

            For Each ctrl As Control In tabEscudo.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabMod.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                End If

            Next

            For Each ctrl As Control In gpArmas.Controls

                If TypeOf (ctrl) Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabGranada.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False


                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabReliq.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If
            Next

        ElseIf tabPane.SelectedTab Is tabEscudo Then

            For Each ctrl As Control In tabArmas.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabMod.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabGranada.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabReliq.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If
            Next

        ElseIf tabPane.SelectedTab Is tabMod Then

            For Each ctrl As Control In tabArmas.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In gpMod.Controls

                If TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                ElseIf TypeOf ctrl Is RadioButton Then

                    CType(ctrl, RadioButton).Checked = False

                End If

            Next

            For Each ctrl As Control In tabEscudo.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabGranada.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabReliq.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If
            Next

        ElseIf tabPane.SelectedTab Is tabGranada Then

            For Each ctrl As Control In tabArmas.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabEscudo.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabMod.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabReliq.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If
            Next

        ElseIf tabPane.SelectedTab Is tabReliq Then

            For Each ctrl As Control In tabArmas.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabEscudo.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabMod.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If

            Next

            For Each ctrl As Control In tabGranada.Controls

                If TypeOf ctrl Is TextBox Then

                    ctrl.Text = ""

                ElseIf TypeOf ctrl Is DataGridView Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is PictureBox Then

                    ctrl.Visible = False

                ElseIf TypeOf ctrl Is ListBox Then

                    DirectCast(ctrl, ListBox).SelectedItems.Clear()

                ElseIf TypeOf ctrl Is ComboBox Then

                    DirectCast(ctrl, ComboBox).SelectedIndex = -1

                End If
            Next

        End If

    End Sub
End Class
