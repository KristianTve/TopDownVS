using static Tensorflow.Binding;
using static Tensorflow.KerasApi;
using Tensorflow;
using NumSharp;

namespace TopDown_AI.Scripts
{
    """
        This class is for defining the neural networks with the TensorFlow.NET package.
        Should also include helper functions, like prediction, weight manupulation,
        (and mutation? Like select some random weight to manipulate.)
        Should have a random generate function to randomly initialize the weights
        Have a crossover function as well? Which employs a specific algorithm for combining the weights (NO)
        Or does a external function pull out the weights by a helper function here and combine them? I think so!
    """
    public class Individual
    {
        // Class contained data:
        private keras.Model sike;
        
        initializeNetwork()
        {
            // input layer
            var inputs = keras.Input(shape: (4), name: "state");

            // convolutional layer
            var x = layers.Dense(32, activation: "relu").Apply(inputs);
            x = layers.Dense(10, activation: "relu").Apply(x);
            x = layers.Dropout(0.5f).Apply(x);

            // output layer
            var outputs = layers.Dense(2).Apply(x);

            // build keras model
            model = keras.Model(inputs, outputs, name: "individualNet");
            model.summary();
            sike = model;
            
            // compile keras model in tensorflow static graph IS THIS NEEDED?? Dont believe so.
            model.compile(optimizer: keras.optimizers.RMSprop(1e-3f),
                loss: keras.losses.CategoricalCrossentropy(from_logits: true),
                metrics: new[] { "acc" });
        }
    }
}