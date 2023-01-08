Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.Xml
Imports System.Windows.Controls.Primitives
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Class MainWindow
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        'Dim request As HttpWebRequest
        'Dim response As HttpWebResponse = Nothing
        'Dim reader As StreamReader
        'Dim rawresp As String
        'Try

        '    request = DirectCast(WebRequest.Create("http://time.jsontest.com/"), HttpWebRequest)
        '    response = DirectCast(request.GetResponse(), HttpWebResponse)
        '    reader = New StreamReader(response.GetResponseStream())


        '    rawresp = reader.ReadToEnd()

        '    Dim json As String = rawresp
        '    Dim jsonObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(json)
        '    Dim jsonArray As JArray = jsonObject("result")
        '    For Each item As JObject In jsonArray
        '        textBox.Text = item.SelectToken("Last").ToString
        '    Next

        'Catch ex As Exception
        '    Console.WriteLine(ex.ToString)
        '    MsgBox(ex.ToString)
        'Finally
        '    If Not response Is Nothing Then response.Close()
        'End Try

        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'Dim json As String = New System.Net.WebClient().DownloadString("http://time.jsontest.com/")
        'Dim parsejson As JObject = JObject.Parse(json)
        'Dim thedate = parsejson.SelectToken("date").ToString()
        'textBox.Text = "Date Is " + thedate

        Dim inFile As StreamReader
        Dim league As New LeagueContainer
        inFile = File.OpenText("data.json")
        While inFile.Peek <> -1
            Dim p As String
            p = inFile.ReadLine
            league = JsonConvert.DeserializeObject(Of LeagueContainer)(p)
        End While
        inFile.Close()
        For Each l As DataItem In league.data.Values
            l.title = "student"
        Next
        Dim outFile As StreamWriter
            outFile = File.AppendText("data2.json")
            outFile.WriteLine(JsonConvert.SerializeObject(league))
            outFile.Close()

    End Sub
End Class
