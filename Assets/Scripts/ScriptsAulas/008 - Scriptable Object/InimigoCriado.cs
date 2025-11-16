using UnityEngine;
using UnityEngine.Rendering;

public class InimigoCriado : MonoBehaviour
{
    public float Vida //propriedade exemplo que serve apenas para saber a porcentagem de vida do player
    {
        get
        {
            return vida / vidaMax;//irá retornar o valor já com um calculo feito
        }
        set
        {
            vida = value;
        }
    }

    private float vida = 1300;
    private float vidaMax = 1500;
    bool superSayajin;

    private float atk;
    public float Atk //propriedade utilizando se o buff supersayajin está alterando o atk
    {
        get 
        {
            if (superSayajin == true) //oermite checar se buffs foram aplicados
            {
                return atk * 100f;
            }
            else
            {
                return atk;
            }
        }
    }


    


    //public float defesa { private get; private set; };//colocando o private no set a informação defesa ainda é publica para utilizar no spawner mas não pode modificar o valor

    private float defesa; //mantém privado para não ter modificação do valor defesa.

    public float Defesa //uma propriedade "Defesa" permite que passe o valor para a variavel privada. ela apenas serve pra
    {
        get 
        { 
            return defesa; 
        }
        set //se remover essa parte o valor não é alterável
        { 
            defesa = value; 
        }
    }










    InimigoSO inimigoData;

    public void ConfigurarInimigo(InimigoSO newData)//recebe as informações e configura o inimigo pra você nesse metodo
    {
        inimigoData = newData;
        GetComponent<Renderer>().material = inimigoData.tipo;
        this.gameObject.name = inimigoData.nome;
        defesa = 100;
    }
}
