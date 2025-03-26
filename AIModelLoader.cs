using UnityEngine;
using Unity.Sentis;

public class AIModelLoader : MonoBehaviour
{
    public string modelPath = "Assets/AIModels/model.onnx";  // تأكد من صحة المسار
    private Model model;
    private SentisInference inferenceEngine;  // استخدم SentisInference بدلاً من interfaceEngine

    void Start()
    {
        // تحميل النموذج
        model = ModelLoader.Load(modelPath);
        inferenceEngine = NewMethod();  // استخدام SentisInference لتحميل النموذج

        Debug.Log("✅ نموذج الذكاء الاصطناعي تم تحميله بنجاح!");
    }

    private SentisInference NewMethod()
    {
        return new SentisInference(model);
    }

    void OnDestroy()
    {
        inferenceEngine?.Dispose(); // تنظيف الذاكرة عند إغلاق المشهد
    }
}
