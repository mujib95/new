Imports System.Drawing
Imports System.IO

Public Class Form1
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim fbd As New FolderBrowserDialog()
        If fbd.ShowDialog() = DialogResult.OK Then
            Dim inputFolder As String = fbd.SelectedPath
            Dim outputFolder As String = Path.Combine(inputFolder, "output")
            Directory.CreateDirectory(outputFolder)

            Dim count As Integer = 0
            For Each file In Directory.GetFiles(inputFolder, "*.jpg")
                Dim fileName As String = Path.GetFileNameWithoutExtension(file)

                ' Parsing nama file
                Dim noLab As String = ""
                Dim nama As String = ""
                Dim umur As String = "?"
                Dim jk As String = "?"

                If fileName.Contains(" - ") Then
                    Dim parts() As String = fileName.Split(New String() {" - "}, StringSplitOptions.None)
                    noLab = parts(0).Trim()
                    Dim pasienPart As String = parts(1).Trim()

                    If pasienPart.Contains("_") Then
                        Dim subParts() As String = pasienPart.Split("_"c)
                        nama = subParts(0).Trim()
                        umur = subParts(1).Replace("Thn", "").Trim()
                    Else
                        nama = pasienPart
                    End If

                    If nama.StartsWith("Ny.") Or nama.StartsWith("Sdri.") Then
                        jk = "Perempuan"
                    Else
                        jk = "Laki-laki"
                    End If
                End If

                ' Buka gambar
                Dim bmp As Bitmap = CType(Bitmap.FromFile(file), Bitmap)
                Dim g As Graphics = Graphics.FromImage(bmp)
                Dim font As New Font("Arial", 20, FontStyle.Bold)
                Dim brush As New SolidBrush(Color.White)

                Dim y As Integer = 20
                g.DrawString("No. Lab       : " & noLab, font, brush, 20, y) : y += 30
                g.DrawString("Nama          : " & nama, font, brush, 20, y) : y += 30
                g.DrawString("Umur          : " & umur & " Thn", font, brush, 20, y) : y += 30
                g.DrawString("Jenis Kelamin : " & jk, font, brush, 20, y)

                ' Simpan hasil
                Dim savePath As String = Path.Combine(outputFolder, "output_" & Path.GetFileName(file))
                bmp.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg)

                g.Dispose()
                bmp.Dispose()

                count += 1
            Next

            MessageBox.Show(count & " file berhasil diproses! Disimpan di folder 'output'.")
        End If
    End Sub
End Class
