using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaDetetora : MonoBehaviour
{
    [SerializeField]
    private string tagDoObjetoVerde = "ObjetoVerde"; // Tag do objeto que faz a caixa mudar para verde
    private AudioSource audioSource;
    public AudioClip certo;
    public AudioClip errado;

    void Start()
    {
    }

    void Update()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato tem a tag definida no Inspector
        if (other.CompareTag(tagDoObjetoVerde))
        {
            MudarCorDaCaixa(Color.green);
            audioSource.PlayOneShot(certo, 0.7f);
        }
        // Se não for a tag do objeto verde, assume outra cor (por exemplo, vermelho)
        else
        {
            MudarCorDaCaixa(Color.red);
            audioSource.PlayOneShot(errado, 0.7f);
        }
    }

    private void MudarCorDaCaixa(Color novaCor)
    {
        Renderer caixaRenderer = GetComponent<Renderer>();

        if (caixaRenderer != null)
        {
            caixaRenderer.material.color = novaCor;
        }
    }
}