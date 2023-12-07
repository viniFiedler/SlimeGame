using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;



public class ComportamentoBotao : MonoBehaviour
{
    // Saber em que Checkpoint estamos
    int Ponto_acerto = 50;
    int Ponto_erro = -100;
    // Parte dos botões aleatórios
    int min = 1;
    int max = 5;
    public TMPro.TextMeshProUGUI Pergunta;
    int correto = 3;
    // Respostas
    Dictionary < int, string > Respostas = new Dictionary < int, string >() {{1,"a"}, {2,"b"}, {3,"Correto"}, {4,"d"}, {5,"e"}};
     
    public List<int> botoes_sheet = new List<int>() {0,0,0,0};
    public List<TMPro.TextMeshProUGUI> opcoes;
    /*
    public TMPro.TextMeshProUGUI opcao1;
    public TMPro.TextMeshProUGUI opcao2;
    public TMPro.TextMeshProUGUI opcao3;
    public TMPro.TextMeshProUGUI opcao4;
    */
    System.Random random = new System.Random(System.Guid.NewGuid().GetHashCode());

    public void trocaCena()
    {
        // volta para a cena anterior
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.UnloadSceneAsync("PC01");
    }
    

    // Para saber Qual botão foi selecionado
    public void botao1()
    {
        if(botoes_sheet[0] == 1)
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_acerto;
        }
        else
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_erro;
        }
        //CheckpointSaver.check_Point = CheckpointSaver.check_Point + 1;    
        
        trocaCena();
        
       
    }
    public void botao2()
    {
        //CheckpointSaver.check_Point = CheckpointSaver.check_Point + 1;    
        
        if(botoes_sheet[1] == 1)
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_acerto;
        }
        else
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_erro;
        }
        
        trocaCena();
    }
    
    // Botao correto
    public void botao3()
    {
        //CheckpointSaver.check_Point = CheckpointSaver.check_Point + 1;    
        
        if(botoes_sheet[2] == 1)
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_acerto;
        }
        else
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_erro;
        }
        trocaCena();
    }
    
    public void botao4()
    {
        //CheckpointSaver.check_Point = CheckpointSaver.check_Point + 1;    
        
        if(botoes_sheet[3] == 1)
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_acerto;
        }
        else
        {
            CheckpointSaver.Points = CheckpointSaver.Points + Ponto_erro;
        }
        
        trocaCena();
    }
    
    
    // Selecionado
    public int Selecionado;
    
    void Start()
    {
    // Parte do checkpoint    
    Debug.Log(CheckpointSaver.check_Point);

    Pergunta.text = "As perguntas?";
    // Desloca o Cursor para clicar nos botões
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;

    // escolher qual Pergunta vai ser
    if(CheckpointSaver.check_Point == 1)
    {
        Respostas = new Dictionary < int, string >() {{1,"0000"}, {2,"1111"}, {3,"0011"}, {4,"1010"}};
        Pergunta.text = "Qual é o número 3 em binário?";
    
    }
    if(CheckpointSaver.check_Point == 2)
    {
        Respostas = new Dictionary < int, string >() {{1,"Z1"}, {2,"UNIVAC 120"}, {3,"ENIAC"}, {4,"APPLE1"}};
        Pergunta.text = "Qual foi o primeiro computador programável do mundo?";
    
    }
    if(CheckpointSaver.check_Point == 3)
    {
        Respostas = new Dictionary < int, string >() {{1,"P"}, {2,"NP"}, {3,"NP-HARD"}, {4,"NP-COMPLETE"}};
        Pergunta.text = "O caixeiro Viajante é de qual categoria?";
    }
    if(CheckpointSaver.check_Point == 4)
    {
        Respostas = new Dictionary < int, string >() {{1,"Alguém"}, {2,"Outra pessoa"}, {3,"Juliana"}, {4,"Não Juliana"}};
        Pergunta.text = "Qual é a melhor professora?";
    }

    // Parte dos botões


    
    int rInt = random.Next(min, max);
        
    opcoes[0].text = Respostas[rInt];
    Respostas.Remove(rInt);
    if(rInt == correto)
        {
            botoes_sheet[0] = 1;
        }
    while ( !Respostas.ContainsKey(rInt))
    {
        rInt = random.Next(min, max);
        

    } 
    opcoes[1].text = Respostas[rInt];
    Respostas.Remove(rInt);
    if(rInt == correto)
        {
            botoes_sheet[1] = 1;
        }
    
    while ( !Respostas.ContainsKey(rInt))
    {
        rInt = random.Next(min, max);

    } 
    opcoes[2].text = Respostas[rInt];
    Respostas.Remove(rInt);
    if(rInt == correto)
        {
            botoes_sheet[2] = 1;
        }

    while ( !Respostas.ContainsKey(rInt))
    {
        rInt = random.Next(min, max);
    } 
    opcoes[3].text = Respostas[rInt];
    Respostas.Remove(rInt);
    if(rInt == correto)
        {
            botoes_sheet[3] = 1;
        }
    }

    void Update()
    {
        
    }
    
}
