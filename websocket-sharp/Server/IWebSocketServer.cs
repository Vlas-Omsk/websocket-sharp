namespace WebSocketSharp.Server
{
  public interface IWebSocketServer
  {
    #region Properties

    /// <summary>
    /// Gets a value indicating whether the server has started.
    /// </summary>
    /// <value>
    /// <c>true</c> if the server has started; otherwise, <c>false</c>.
    /// </value>
    bool IsListening { get; }

    /// <summary>
    /// Gets the management function for the WebSocket services provided by
    /// the server.
    /// </summary>
    /// <value>
    /// A <see cref="WebSocketServiceManager"/> that manages the WebSocket
    /// services provided by the server.
    /// </value>
    WebSocketServiceManager WebSocketServices { get; }

    #endregion

    #region Methods

    /// <summary>
    /// Starts receiving incoming requests.
    /// </summary>
    /// <remarks>
    /// This method does nothing if the server has already started or
    /// it is shutting down.
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    ///   <para>
    ///   There is no server certificate for secure connection.
    ///   </para>
    ///   <para>
    ///   -or-
    ///   </para>
    ///   <para>
    ///   The underlying <see cref="HttpListener"/> has failed to start.
    ///   </para>
    /// </exception>
    void Start ();

    /// <summary>
    /// Stops receiving incoming requests.
    /// </summary>
    /// <remarks>
    /// This method does nothing if the server is not started,
    /// it is shutting down, or it has already stopped.
    /// </remarks>
    void Stop ();

    #endregion
  }
}
